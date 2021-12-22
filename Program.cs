﻿using System;
using System.IO;

namespace NationalIdVerification
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //string input = "34409157850";
            //Console.WriteLine(ValidateControlDigit(input));
            string filePath = "C:\\test\\natids.txt";
            ReadFileValidateNationalID(filePath);
        }

        public static void ReadFileValidateNationalID(string filePath)
        {
            #region create directory and result file to store validation result

            string currentPath = Directory.GetCurrentDirectory();
            string folderName = "output";
            string fullPath = Path.Combine(currentPath, folderName);
            string fullFilePath = Path.Combine(fullPath, "result.txt");
            if (!Directory.Exists(fullPath))
                Directory.CreateDirectory(fullPath);
            if (!File.Exists(fullFilePath))
                File.WriteAllText(fullFilePath, "");
            else
                File.WriteAllText(fullFilePath, String.Empty);
            #endregion create directory and result file to store validation result

            #region read each line in file and validate writing result in result
            // Read file per
            string line;
            using (var fs = File.OpenRead(filePath))
            using (var reader = new StreamReader(fs))
                while ((line = reader.ReadLine()) != null)
                {
                    var result = ValidateControlDigit(line);
                    var validationResult = $"{line} {result}";
                    File.AppendAllText(fullFilePath, validationResult + Environment.NewLine);
                }

            #endregion read each line in file and validate writing result in result
        }

        private static bool ValidateControlDigit(string nId)
        {
            if (nId.Length != 11) return false;
            if (!char.IsDigit(nId[0])) return false;
            int sum = 0; int start = 1; int cLastDigit = -1;
            int lastDigit = char.IsDigit(nId[nId.Length - 1]) ? 
                int.Parse(nId[nId.Length - 1].ToString()) :
                -1;

            string nationId = nId.Substring(0, 10);

            ComputeSum(ref sum, ref start, nationId);
            int computed = sum % 11;
            if (computed < 10)
                cLastDigit = computed;
            else
            {
                start = 3;
                ComputeSum(ref sum, ref start, nationId);
                computed = sum % 11;
                cLastDigit = SetLastDigit(sum, cLastDigit, computed);
            }

            if (lastDigit == cLastDigit)
                return true;

            return false;
        }

        private static int SetLastDigit(int sum, int cLastDigit, int computed)
        {
            if (computed < 10)
                cLastDigit = computed;
            else if (sum % 11 == 10)
                cLastDigit = 0;
            return cLastDigit;
        }

        private static void ComputeSum(ref int sum, ref int start, string nationId)
        {
            foreach (char c in nationId)
            {
                int currDigit = int.Parse(c.ToString());
                sum += currDigit * start;
                if (start < 9)
                    start++;
                else
                    start = 1;
            }
        }
    }
}