using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace MapCSVtoEntities
{
    public class CreateClass
    {
        public static string GenerateCodes(string fileLocation, char csv = ',', string classAttribute = "", string propertyAttribute = "")
        {
            string[] lines = File.ReadAllLines(fileLocation);
            string[] colNames = lines.First().Split(csv).Select(val => val.Trim()).ToArray();
            string[] data = lines.Skip(1).ToArray();
            string className = Path.GetFileNameWithoutExtension(fileLocation);

            if (string.IsNullOrWhiteSpace(propertyAttribute) == false)
                propertyAttribute += "\n\t";
            if (string.IsNullOrWhiteSpace(propertyAttribute) == false)
                classAttribute += "\n";

            string codeText = String.Format("{0}public class {1} {{ \n", classAttribute, className);

            for (int i = 0; i < colNames.Length; i++)
            {
                var cName = Regex.Replace(colNames[i], @"[\s\.]", string.Empty, RegexOptions.IgnoreCase);
                if (string.IsNullOrEmpty(cName))
                    cName = "Column" + (i + 1);
                codeText += "\t" + CreateProperties(data, i, csv, cName, propertyAttribute) + "\n\n";
            }

            codeText += "}\n";

            return codeText;
        }

        public static string CreateProperties(string[] data, int columnIndex, char csv, string columnName, string attribute = null)
        {
            string[] columnValues = data.Select(line => line.Split(csv)[columnIndex].Trim()).ToArray();
            string type;

            if (CheckInt(columnValues))
            {
                type = "int";
            }
            else if (CheckDouble(columnValues))
            {
                type = "double";
            }
            else if (CheckByte(columnValues))
            {
                type = "byte";
            }
            else if (CheckBool(columnValues))
            {
                type = "bool";
            }
            else if (CheckDateTime(columnValues))
            {
                type = "DateTime";
            }
            else
            {
                type = "string";
            }

            string properties = String.Format("{0}public {1} {2} {{ get; set; }}", attribute, type, columnName);
            return properties;
        }

        public static bool CheckInt(string[] values)
        {
            int result;
            return values.All(val => int.TryParse(val, out result));
        }

        public static bool CheckDouble(string[] values)
        {
            double result;
            return values.All(val => double.TryParse(val, out result));
        }

        public static bool CheckByte(string[] values)
        {
            Byte result;
            return values.All(val => Byte.TryParse(val, out result));
        }

        public static bool CheckBool(string[] values)
        {
            bool result;
            return values.All(val => bool.TryParse(val, out result));
        }

        public static bool CheckDateTime(string[] values)
        {
            DateTime result;
            return values.All(val => DateTime.TryParse(val, out result));
        }

    }
}
