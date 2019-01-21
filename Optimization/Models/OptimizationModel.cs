using System.Collections.Generic;

namespace Optimization.Models
{
    public class OptimizationModel
    {
        /// <summary>
        /// ������ �������� �����
        /// </summary>
        public List<BlastFurnace> Furnaces { get; set; }

        /// <summary>
        /// ��������� �����, ���/(�� �����)
        /// </summary>
        public double CoxCost { get; set; }

        /// <summary>
        /// ��������� ���������� ����, ���/(�3 ��)
        /// </summary>
        public double GasCost { get; set; }

        /// <summary>
        /// ������ �� ������� ���������� ���� � ����� �� ����, �3/� 
        /// </summary>
        public int GasSupply { get; set; }

        /// <summary>
        /// ������ ����� �� ����, �/�
        /// </summary>
        public int CoxSupply { get; set; }

        /// <summary>
        /// ��������� ������������ ������ � ����, �/�
        /// </summary>
        public int RequiredIronPerformance { get; set; }

        /// <summary>
        /// ��������� �����������. ������������ ������� �������
        /// </summary>
        public double OptimizedFunctionResult { get; set; }
    }
}