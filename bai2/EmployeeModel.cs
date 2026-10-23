using System;

namespace bai2
{
    public class EmployeeModel
    {
        public string EmployeeId { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;
        public decimal BaseSalary { get; set; }
        public string AvatarPath { get; set; } = string.Empty;

        public string ToCsvLine()
        {
            return $"{EmployeeId},{FullName},{Position},{BaseSalary},{AvatarPath}";
        }

        public static EmployeeModel? FromCsvLine(string csvLine)
        {
            var parts = csvLine.Split(',');
            if (parts.Length < 5) return null;

            return new EmployeeModel
            {
                EmployeeId = parts[0].Trim(),
                FullName = parts[1].Trim(),
                Position = parts[2].Trim(),
                BaseSalary = decimal.TryParse(parts[3].Trim(), out decimal salary) ? salary : 0,
                AvatarPath = parts[4].Trim()
            };
        }
    }
}