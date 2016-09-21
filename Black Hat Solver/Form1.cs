using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Black_Hat_Solver
{
    public partial class Form1 : Form
    {
        private List<string> dict, fastDict;
        private bool dictionariesLoaded = false;
        private bool normaldictionaryLoaded = false;
        private bool fastdictionaryLoaded = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dictionariesLoaded = false;

            (new Thread(() => {
                dict = loadDictionary("F:\\Dropbox\\Documents\\School\\MATH549\\Black Hat\\Black Hat Solver\\Black Hat Solver\\bin\\Debug\\Dict.txt");
                normaldictionaryLoaded = true;
            })
            ).Start();
            (new Thread(() =>
            {
                fastDict = loadDictionary("F:\\Dropbox\\Documents\\School\\MATH549\\Black Hat\\Black Hat Solver\\Black Hat Solver\\bin\\Debug\\Fast Dict.txt");
                fastdictionaryLoaded = true;
            })
            ).Start();
            (new Thread(() =>
            {
                while (!normaldictionaryLoaded || !fastdictionaryLoaded)
                {
                    Thread.Sleep(1000);

                }
                dictionariesLoaded = true;
                System.Windows.Forms.MessageBox.Show("Dictionary Loaded, you may now start cracking!");
            })
).Start();
            
            wordScoreValue.Text = "";
            cipherValue.Text = "";
            keyValue.Text = "";
        }

        private List<string> loadDictionary(string file)
        {
            try
            {
                List<string> dict = new List<string>();
                var Lines = File.ReadAllLines(file).ToList<string>();

                //var Lines = ScriptRW.readfile(file);
                Regex scriptStmtFormat = new Regex(@"^(?<word>[a-zA-Z]+)$");
                object dictLoadLock = new object();
                Parallel.ForEach(Lines, new ParallelOptions { MaxDegreeOfParallelism = 4 }, line =>
                //foreach (string line in Lines)
                {
                    Console.WriteLine("Line: " + line);
                    var instructionStmtMatch = scriptStmtFormat.Match(line);

                    if (instructionStmtMatch.Success)
                    {
                        Console.WriteLine("Word: " + instructionStmtMatch.Groups["word"].Value);
                        lock (dictLoadLock)
                        {
                            dict.Add(instructionStmtMatch.Groups["word"].Value);
                        }
                    }
                }
                );
                return dict;
            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show("Unable to Open File\nDetails:\n" + err);
                return new List<string>();
            }
        }

        //private readonly 
        private int wordScore(List<string> words, string text)
        {
            object dictLock = new object();
            int score = 0;
            //Parallel.ForEach(words, word => // this is slower for some reason
            foreach (string word in words)
            {
                //Console.WriteLine("Checking for Word: " + word);
                //int charPosition = 0;
                Parallel.For(0, text.Length + 1, new ParallelOptions { MaxDegreeOfParallelism = 4 }, charPosition =>
                //for (int charPosition = 0; charPosition < text.Length; charPosition++)
                {
                    int tempCharPosition = charPosition;
                    int wordPosition = 0;
                    while (word.Length > wordPosition && text.Length > tempCharPosition && char.ToUpperInvariant(word[wordPosition]) == char.ToUpperInvariant(text[tempCharPosition]))
                    {
                        wordPosition++;
                        tempCharPosition++;
                    }
                    if (word.Length != 0 && wordPosition == word.Length)
                    {
                        lock (dictLock)
                        {
                            //Console.WriteLine("Word Found: " + word + " worth: " + Math.Pow(word.Length,2));
                            score += (int)Math.Pow(word.Length, 2);
                        }
                    }
                }
                );
            }
            //);
            return score;
        }
        private int letterToNumber(char letter)
        {
            return char.ToUpper(letter) - 65;
        }
        private char numberToLetter(int number)
        {
            return (char)(number + 65);
        }

        private result solveCeaser(int key, string inputText)
        {
            char[] tempText = inputText.ToCharArray();
            for (int characterPosition = 0; characterPosition < tempText.Length; characterPosition++)
            {
                tempText[characterPosition] = numberToLetter( ((letterToNumber(tempText[characterPosition]) + key ) % 26) );
            }
            return new result(new string(tempText), wordScore(fastDict, new string(tempText)));
        }

        private void wordCountButton_Click(object sender, EventArgs e)
        {
            wordScoreValue.Text = wordScore(fastDict, cypherTextBox.Text).ToString();
            cipherValue.Text = "None";
            keyValue.Text = "N\\A";
            plainTextBox.Text = cypherTextBox.Text;
            //Console.WriteLine("Score: " + wordScore(loadDictionary("F:\\Dropbox\\Documents\\School\\MATH549\\Black Hat\\Black Hat Solver\\Black Hat Solver\\bin\\Debug\\Dict.txt"),textBox1.Text));
        }

        private void ceaserButton_Click(object sender, EventArgs e)
        {
            //Ceaser button
            if(ceasarModeRadioSmart.Checked)
            {
                //smart mode
            }
            else if(ceasarModeRadioBruteForce.Checked)
            {
                result highestResult = new result("",-1);
                result tempResult;
                int key = -1;
                for(int letter = 0; letter < 26; letter++)
                {
                    tempResult = solveCeaser(letter, cypherTextBox.Text);
                    Console.WriteLine("Key: " + letter);
                    Console.WriteLine("Score: " + tempResult.getScore());
                    Console.WriteLine("Text: " + tempResult.getText());
                    if (tempResult.getScore() > highestResult.getScore())
                    {
                        highestResult = tempResult;
                        key = letter;
                    }
                }
                wordScoreValue.Text = highestResult.getScore().ToString();
                cipherValue.Text = "Substitution";
                keyValue.Text = key.ToString();
                plainTextBox.Text = highestResult.getText();
            }
        }

        //private readonly 
        private void vigenereButton_Click(object sender, EventArgs e)
        {
            object vigenereLock = new object();
            //vigenere button
            if (vigenereModeRadioSmart.Checked)
            {
                //smart mode
            }
            else if (vigenereModeRadioBruteForce.Checked && !vigenereCheckBoxUseDict.Checked)
            {
                result highestResult = new result("", -1);
                result tempResult;
                char[] key = { };
                //todo add some checking to make sure textbox value is actually a number
                Parallel.For(Convert.ToInt32(VigenereMinSize.Text), Convert.ToInt32(vigenereMaxSize.Text) + 1, new ParallelOptions { MaxDegreeOfParallelism = 4 }, keySize =>
                //{
                // ProcessFile(filenames[i]);
                //});
                //for (int keySize = Convert.ToInt32(subMinSize.Text); keySize <= Convert.ToInt32(subMaxSize.Text); keySize++)
                {
                    char[] tempKey = new char[keySize];
                    char[] finalKey = new char[keySize];
                    int offset = 0;
                    //add some code to handle partial keys
                    for (int i = 0; i < possibleKeyTextBox.Text.Length; i++)
                    {
                        tempKey[i] = possibleKeyTextBox.Text[i];
                        finalKey[i] = possibleKeyTextBox.Text[i];
                        offset++;
                    }
                    for (int i = offset; i < keySize; i++)
                    {
                        tempKey[i] = 'A';
                        finalKey[i] = 'Z';
                    }
                    bool isDone = false;
                    while (!isDone)
                    {
                        tempResult = solveVigenere(tempKey, cypherTextBox.Text);
                        Console.WriteLine("Key: " + new string(tempKey) + " Final Key: " + new string(finalKey));
                        //Console.WriteLine("Text: " + tempResult.getText());
                        if (tempResult.getScore() > highestResult.getScore())
                        {
                            lock (vigenereLock)
                            {
                                if (tempResult.getScore() > highestResult.getScore())
                                {
                                    Console.WriteLine("New High Key: " + new string(tempKey));
                                    Console.WriteLine("New High Score: " + tempResult.getScore());
                                    Console.WriteLine("New High Text: " + tempResult.getText());
                                    highestResult = tempResult;
                                    key = tempKey;
                                }
                            }
                        }
                        if (new string(tempKey).ToUpper() == new string(finalKey).ToUpper())
                        {
                            isDone = true;
                        }
                        tempKey = incrementKey(tempKey);
                    }
                });
                wordScoreValue.Text = highestResult.getScore().ToString();
                cipherValue.Text = "Vigenère";
                keyValue.Text = new string(key);
                plainTextBox.Text = highestResult.getText();
            }
            else if (vigenereModeRadioBruteForce.Checked && vigenereCheckBoxUseDict.Checked)
            {
                result highestResult = new result("", -1);
                result tempResult;
                //char[] key = { };
                string highestKey = "";
                Parallel.ForEach(dict, new ParallelOptions { MaxDegreeOfParallelism = 4 }, key =>
                {
                    if (key.Length >= Convert.ToInt32(VigenereMinSize.Text) && key.Length <= Convert.ToInt32(vigenereMaxSize.Text) && key.Contains(possibleKeyTextBox.Text))
                    {
                        tempResult = solveVigenere(key.ToCharArray(), cypherTextBox.Text);
                        Console.WriteLine("Key: " + key);
                        //Console.WriteLine("Text: " + tempResult.getText());
                        if (tempResult.getScore() > highestResult.getScore())
                        {
                            lock (vigenereLock)
                            {
                                Console.WriteLine("New High Key: " + key);
                                Console.WriteLine("New High Score: " + tempResult.getScore());
                                Console.WriteLine("New High Text: " + tempResult.getText());
                                highestResult = tempResult;
                                highestKey = key;
                            }
                        }
                    }
                    else
                    {
                        //Console.WriteLine("Ignoring Word");
                    }
                }
                );
                wordScoreValue.Text = highestResult.getScore().ToString();
                cipherValue.Text = "Substitution";
                keyValue.Text = highestKey;
                plainTextBox.Text = highestResult.getText();
            }
        }
        private result solveVigenere(char[] key, string cypherText)
        {
            char[] tempText = cypherText.ToCharArray();
            for (int letter = 0; letter < tempText.Length; letter++)
            {
                int tempNumber = (letterToNumber(tempText[letter]) - letterToNumber(key[letter % key.Length]) );
                if (tempNumber < 0)
                {
                    tempNumber += 26;
                }
                tempText[letter] = numberToLetter(tempNumber);
                //tempText[letter] = numberToLetter(((letterToNumber(tempText[letter]) + letterToNumber(key[letter % key.Length]) - 1) % 26) + 1);
            }
            return new result(new string(tempText), wordScore(fastDict, new string(tempText)));
        }

        private char[] incrementKey(char[] key)
        {
            int remainder = 0;
            for (int letter = key.Length - 1; letter >= 0; letter--)
            {
                int newValue = letterToNumber(key[letter]) + remainder;
                if (letter == key.Length - 1)
                {
                    newValue++;
                }
                if (newValue > 26)
                {
                    newValue = ((newValue - 1) % 26) + 1;
                    remainder = 1;
                }
                else
                {
                    remainder = 0;
                }
                key[letter] = numberToLetter(newValue);
            }
            return key;
        }

        private void vigenereModeRadioSmart_CheckedChanged(object sender, EventArgs e)
        {
            vigenereCheckBoxUseDict.Checked = true;
        }

        private void vigenereCheckBoxUseDict_CheckedChanged(object sender, EventArgs e)
        {
            if (!vigenereCheckBoxUseDict.Checked && vigenereModeRadioSmart.Checked)
            {
                vigenereCheckBoxUseDict.Checked = true;
            }
        }
    }

    class result
    {
        private string text;
        private int score;
        public result(string text, int score)
        {
            this.text = text;
            this.score = score;
        }

        public string getText()
        {
            return this.text;
        }
        public int getScore()
        {
            return this.score;
        }
    }
}
