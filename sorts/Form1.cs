using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sorts
{

    public partial class Sorting_form : Form
    {
        public Sorting_form()
        {
            InitializeComponent();
            chosen_one = null;
        }

        private const int num_of_sorts = 16;
        private int? chosen_one;

        private void Start_button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Stopwatch time = new System.Diagnostics.Stopwatch();

            Arr_output.Clear();
            Sort_type sort_index;
            Sorts sort = new Sorts();
            string str;
            int[] Arr;
            if (chosen_one != null)
            {
                sort_index = (Sort_type)chosen_one;
            }            
            else
            {
                Arr_output.Clear();
                Arr_output.AppendText("Выберите сортировку!");
                return;
            }
            if (!Arr_rand_check.Checked && !Arr_input_check.Checked)
            {
                Arr_output.Clear();
                Arr_output.AppendText("Требуются входные данные!");
                return;
            }
            if (Arr_rand_check.Checked)
            {
                str = Arr_size.Text;
                if (!Int32.TryParse(str, out int Arr_s))
                {
                    Arr_output.Clear();
                    Arr_output.AppendText("Невозможно считать размер массива!");
                    return;
                }
                if (Arr_s < 2)
                {
                    Arr_output.Clear();
                    Arr_output.AppendText("Массивы меньше двух элементов не рассматриваются!");
                    return;
                }

                str = Arr_range_min.Text;
                if (!Int32.TryParse(str, out int Arr_min))
                {
                    Arr_output.Clear();
                    Arr_output.AppendText("Невозможно считать нижнюю границу для генерации элементов!");
                    return;
                }
                str = Arr_range_max.Text;
                if (!Int32.TryParse(str, out int Arr_max))
                {
                    Arr_output.Clear();
                    Arr_output.AppendText("Невозможно считать верхнюю границу для генерации элементов!");
                    return;
                }

                if (Arr_min >= Arr_max)
                {
                    Arr_output.Clear();
                    Arr_output.AppendText("Верхняя граница меньше нижней!");
                    return;
                }

                sort = new Sorts(sort_index, Arr_s, Arr_min, Arr_max);

            }
            if (Arr_input_check.Checked)
            {
                str = Arr_input.Text;
                string[] Spliting;
                char[] separate = { ' ', ',' };
                Spliting = str.Split(separate, StringSplitOptions.RemoveEmptyEntries);
                int len = Spliting.Length;
                if (len < 2)
                {
                    Arr_output.Clear();
                    Arr_output.AppendText("Массивы меньше двух элементов не рассматриваются!");
                    return;
                }

                Arr = new int[len];
                for (int count = 0; count < len; count++)
                {
                    if (!Int32.TryParse(Spliting[count], out Arr[count]))
                    {
                        Arr_output.Clear();
                        Arr_output.AppendText("Невозможно считать массив! Используйте целые числа.");
                        return;
                    }
                }

                sort = new Sorts(sort_index, Arr);
            }
            if (!Dont_show.Checked)
            {
                time.Start();
                Arr = sort.GetArr();
                Arr_input.Clear();
                foreach (int _obj in Arr)
                {
                    Arr_input.AppendText(_obj.ToString());
                    Arr_input.AppendText(" ");
                }
                time.Stop();
                Arr_input.AppendText("\nВремя выполнения: ");
                Arr_input.AppendText(time.ElapsedMilliseconds.ToString());
                Arr_input.AppendText(" мс.\n");
            }
            time.Reset();
            time.Start();
            int[] Sorted = sort.It();
            time.Stop();
            Arr_output.AppendText("Время выполнения: ");
            Arr_output.AppendText(time.ElapsedMilliseconds.ToString());
            Arr_output.AppendText(" мс.\n");
            if (!Dont_show.Checked)
            {
                time.Restart();
                foreach (int _obj in Sorted)
                {
                    Arr_output.AppendText(_obj.ToString());
                    Arr_output.AppendText(" ");
                }
                time.Stop();
                Arr_output.AppendText("\nВремя выполнения: ");
                Arr_output.AppendText(time.ElapsedMilliseconds.ToString());
                Arr_output.AppendText(" мс.\n");
            }
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {

            Arr_input.Clear();
            Arr_output.Clear();
            Sort_choose.ClearSelected();            
            Sort_choose.SetItemChecked((int)chosen_one, false);           
            chosen_one = null;
            Arr_rand_check.Checked = false;
            Arr_input_check.Checked = false;
            Arr_rand_check.Enabled = true;
            Arr_input_check.Enabled = true;
            Arr_size.Clear();
            Arr_range_min.Clear();
            Arr_range_max.Clear();
            Dont_show.Checked = false;
        }

        private void Sort_choose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chosen_one != null)
            {
                Sort_choose.SetItemChecked((int)chosen_one, false);

            }
            chosen_one = Sort_choose.SelectedIndex;           
        }

        private void Arr_rand_check_CheckedChanged(object sender, EventArgs e)
        {

            Arr_rand_check.Enabled = false;
            Arr_input_check.Checked = false;
            Arr_input_check.Enabled = true;
            Arr_size.ReadOnly = false;
            Arr_range_min.ReadOnly = false;
            Arr_range_max.ReadOnly = false;
            Arr_input.ReadOnly = true;
        }

        private void Arr_input_check_CheckedChanged(object sender, EventArgs e)
        {

            Arr_input_check.Enabled = false;
            Arr_rand_check.Checked = false;
            Arr_rand_check.Enabled = true;
            Arr_size.ReadOnly = true;
            Arr_range_min.ReadOnly = true;
            Arr_range_max.ReadOnly = true;
            Arr_input.ReadOnly = false;
        }
    }

    public enum Sort_type
    {
        Bubble = 0,
        Insertion = 1,
        Merge = 2,
        Tree_sort = 3,
        Bucket = 4,
        Radix_MSD = 5,
        Radix_LSD = 6,
        Selection = 7,
        Comb_sort = 8,
        Shell_sort = 9,
        Heapsort = 10,
        Smoothsort = 11,
        Quicksort = 12,
        Introsort = 13,
        Patience = 14,
        Bead = 15
    }

    public class Sorts
    {
        private int[] Arr { set; get; }
        private Sort_type Type;
        private int max;
        public int[] GetArr()
        {
            return Arr;
        }

        public Sorts()
        {
            //Random rnd = new Random();
            //Type = (Sort_type)rnd.Next(0, 15);
            //Arr = Arr_random(rnd.Next(100, Int32.MaxValue-1), 0, Int32.MaxValue - 1);
        }

        public Sorts(Sort_type _T, int _Arr_size, int _Min, int _Max)
        {
            Type = _T;
            Arr = Arr_random(_Arr_size, _Min, _Max);
            max = Find_max();
        }

        public Sorts(Sort_type _T, int[] _Input)
        {
            Type = _T;
            Arr = _Input;
            max = Find_max();
        }

        public int[] It()
        {
            switch (Type)
            {
                case Sort_type.Bubble:
                    Bubble_sort();
                    break;
                case Sort_type.Insertion:
                    Insertion_sort();
                    break;
                case Sort_type.Merge:
                    Merge_sort();
                    break;
                case Sort_type.Tree_sort:
                    Tree_sort();
                    break;
                case Sort_type.Bucket:
                    break;
                case Sort_type.Radix_MSD:
                    break;
                case Sort_type.Radix_LSD:
                    Radix_LSD();
                    break;
                case Sort_type.Selection:
                    break;
                case Sort_type.Comb_sort:
                    break;
                case Sort_type.Shell_sort:
                    break;
                case Sort_type.Heapsort:
                    break;
                case Sort_type.Smoothsort:
                    break;
                case Sort_type.Quicksort:
                    break;
                case Sort_type.Introsort:
                    break;
                case Sort_type.Patience:
                    break;
                case Sort_type.Bead:
                    break;
            }
            return Arr;
        }

        private int Find_max()
        {           
            int m = 0;
            foreach (int _obj in Arr)
            {
               m =  _obj > m ? _obj : m;
            }
            return m;
        }

        private int[] Arr_random(int _Size, int _Min, int _Max)
        {
            int[] Arr_t = new int[_Size];
            Random rnd = new Random();
            for (int count = 0; count < _Size; count++)
            {
                Arr_t[count] = rnd.Next(_Min, _Max);
            }
            return Arr_t;
        }

        private void Bubble_sort()
        {
            int buf;
            for (int count_i = 0; count_i < Arr.Length - 1; count_i++)
            {
                for (int count_j = 0; count_j < Arr.Length - 1; count_j++)
                {
                    if (Arr[count_j] > Arr[count_j + 1])
                    {
                        buf = Arr[count_j];
                        Arr[count_j] = Arr[count_j + 1];
                        Arr[count_j + 1] = buf;
                    }
                }
            }
        }

        private void Insertion_sort()
        {
            int buf;
            int count_j;
            for (int count_i = 1; count_i < Arr.Length; count_i++)
            {
                buf = Arr[count_i];
                count_j = count_i - 1;
                while (count_j >= 0 && Arr[count_j] > buf)
                {
                    Arr[count_j + 1] = Arr[count_j];
                    count_j--;
                }
                Arr[count_j + 1] = buf;
            }
        }

        struct W
        {
            public List<int> list;
            public int weight;
        }

        private List<int> Merge(List<int> _A, List<int> _B)
        {
            List<int> list_out = new List<int>();
            int count_a = 0;
            int count_b = 0;
            while (count_a < _A.Count && count_b < _B.Count)
            {
                if (_A[count_a] > _B[count_b])
                {
                    list_out.Add(_B[count_b]);
                    count_b++;
                }
                else
                {
                    list_out.Add(_A[count_a]);
                    count_a++;
                }
            }
            if (count_a == _A.Count)
            {
                while (count_b < _B.Count)
                {
                    list_out.Add(_B[count_b]);
                    count_b++;
                }
            }
            else //if (count_b == _B.Count)
            {
                while (count_a < _A.Count)
                {
                    list_out.Add(_A[count_a]);
                    count_a++;
                }
            }
            return list_out;
        }

        private void Merge_sort()
        {
            W temp_list_1 = new W();
            // W temp_list_2 = new W();
            Stack<W> stack = new Stack<W>();
            int[] temp = new int[1];
            temp[0] = Arr[0];
            temp_list_1.list = new List<int>(temp);
            temp_list_1.weight = 1;
            stack.Push(temp_list_1);
            temp[0] = Arr[1];
            temp_list_1.list = new List<int>(temp);
            temp_list_1.weight = 1;
            stack.Push(temp_list_1);
            int len = Arr.Length;
            for (int count = 2; count < len; count++)
            {
                temp_list_1 = stack.Pop();
                while (stack.Count > 0 && temp_list_1.weight == stack.Peek().weight)
                {
                    temp_list_1.list = Merge(temp_list_1.list, stack.Pop().list);
                    temp_list_1.weight++;
                }
                stack.Push(temp_list_1);
                temp[0] = Arr[count];
                temp_list_1.list = new List<int>(temp);
                temp_list_1.weight = 1;
                stack.Push(temp_list_1);
            }
            temp_list_1 = stack.Pop();
            while (stack.Count > 0)
            {
                temp_list_1.list = Merge(temp_list_1.list, stack.Pop().list);
            }

            Arr = temp_list_1.list.ToArray();
        }

        private class Leaf
        {
            public int key;
            public Leaf left;
            public Leaf right;

            public Leaf()
            {
                key = 0;
                left = null;
                right = null;
            }

            public Leaf(int _obj)
            {
                key = _obj;
                left = null;
                right = null;
            }

            public void Add(int _obj)
            {
                if (_obj < key)
                {
                    if (left == null)
                    {
                        left = new Leaf(_obj);
                        return;
                    }
                    left.Add(_obj);
                    return;
                }
                if (right == null)
                {
                    right = new Leaf(_obj);
                    return;
                }
                right.Add(_obj);
                return;
            }

            public List<int> Sort_tree(List<int> _list)
            {
                if (left != null)
                {
                    _list = left.Sort_tree(_list);
                }
                _list.Add(key);
                if (right != null)
                {
                    _list = right.Sort_tree(_list);
                }
                return _list;
            }
        }

        private void Tree_sort()
        {
            Leaf tree = new Leaf(Arr[0]);
            int len = Arr.Length;
            for (int count = 1; count < len; count++)
            {
                tree.Add(Arr[count]);
            }
            List<int> sorted = new List<int>();
            sorted = tree.Sort_tree(sorted);
            Arr = sorted.ToArray();
        }

        private int Max_rank()
        {
            int m = max;
            int count = 0;
            while (m!=0)
            {
                m /= 10;
                count++;
            }
            return count;
        }

        private int Get_digit(int _num, int _rank)
        {
            int count = 1;
            while (count != _rank)
            {
                _num /= 10;
                count++;
            }
            return _num % 10;
        }

        private void Radix_LSD()
        {
            int rank = Max_rank();
            int[] digits = new int[10];
            int[] Brr;
            int digit=0;
            int count = 0;
            int buf;
            for (int count_i = 1;count_i<=rank; count_i++)
            {
                for (int count_k = 0; count_k < 10; count_k++)
                {
                    digits[count_k] = 0;
                    digit = 0;
                }
                for (int count_j = 0; count_j<Arr.Length; count_j++)
                {
                    digit = Get_digit(Arr[count_j], count_i);
                    digits[digit]++;
                }
                count = 0;
                for (int count_k = 0; count_k < 10; count_k++)
                {
                    buf = digits[count_k];
                    digits[count_k] = count;
                    count += buf;
                }
                Brr = new int[Arr.Length];
                for (int count_j = 0; count_j < Arr.Length; count_j++)
                {
                    digit = Get_digit(Arr[count_j], count_i);
                    Brr[digits[digit]] = Arr[count_j];
                    digits[digit]++;
                }
                Arr = Brr;
            }
        }
    }
}
