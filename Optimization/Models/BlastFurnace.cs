using System;

namespace Optimization.Models
{
    public class BlastFurnace
    {

        
        public Int32 FurnanceId { get; set; }
        /// <summary>
        /// ������ ���������� ���� � ������� �������, �3/�
        /// </summary>
        public double GasExpenseBasePeriod { get; set; }

        /// <summary>
        /// ���������� ���������� ������ ���������� ����, �3/�
        /// </summary>
        public double MinGasExpense { get; set; }
        
        /// <summary>
        /// ����������� ���������� ������ ���������� ����, �3/�
        /// </summary>
        public double MaxGasExpense { get; set; }

        /// <summary>
        /// ������ ����� � ������� �������, �/���
        /// </summary>
        public double CoxExpenseBasePeriod { get; set; }

        /// <summary>
        /// ���������� ������ ����� � ������� �������, �� ����� /(�3 ��)
        /// </summary>
        public double CoxReplacementEquivalent { get; set; }

        /// <summary>
        /// ������������������ �� ������ � ������� �������, � /�
        /// </summary>
        public double IronPerformance { get; set; }

        /// <summary>
        /// ������������� ����������� ������� � ������� �������, ��
        /// </summary>
        public int TheoreticTemperatureBasePeriod { get; set; }
        
        /// <summary>
        /// ���������� ���������� ������������� ����������� �������, ��
        /// </summary>
        public double MinTemperature { get; set; }
        /// <summary>
        /// ����������� ���������� ������������� ����������� �������, ��
        /// </summary>
        public double MaxTemperature { get; set; }

        /// <summary>
        /// ������ ����. ��� ���������� ���������
        /// </summary>
        public double GasExpenseToReadjust { get; set; }

        /// <summary>
        /// ��������� ������������ ������ ��� ��������� ��, � ���/(�3 ��)
        /// </summary>
        public double DeltaIronPerformanceGasChanged { get; set; }
        
        /// <summary>
        /// ��������� ������������ ������ ��� ���������� ������� �����, � ���/(�� �����)
        /// </summary>
        public double DeltaIronPerformanceCoxChanged { get; set; }

        /// <summary>
        /// ��������� ����������� ������� ��� ���������� ������� �� �� 1 �3/�
        /// </summary>
        public double DeltaTemperatureGasChanged { get; set; }



    }
}