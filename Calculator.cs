using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Design
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            CB_ConvertFrom.SelectedIndex = 0;
            CB_ConvertTo.SelectedIndex = 1;
        }

        public enum enComputerSystems
        {
            Binary,
            Octal,
            Decimal,
            Hexadecimal
        }

        private static char[] Hexadecimal_ArrElements = new char[16]
        { '0' , '1' , '2' , '3' , '4' , '5',
          '6' , '7' , '8' , '9' , 'A' , 'B' , 'C' , 'D' , 'E' , 'F'};

        public class clsSettings
        {
            public enComputerSystems ConvertFrom;
            public enComputerSystems ConvertTo;
        }

        private clsSettings MySettings = new clsSettings();

        private void InputPanel_Click(object sender, System.EventArgs e)
        {
            TB_Input.Focus();
        }

        private void BT_Swap_Click(object sender, System.EventArgs e)
        {
            byte TempIndex = (byte)CB_ConvertFrom.SelectedIndex;
            CB_ConvertFrom.SelectedIndex = CB_ConvertTo.SelectedIndex;
            CB_ConvertTo.SelectedIndex = TempIndex;
        }

        private void BT_Convert_Click(object sender, System.EventArgs e)
        {
            if (TB_Input.Text.Length == 0)
                return;

            if (CB_ConvertFrom.SelectedIndex == CB_ConvertTo.SelectedIndex)
            {
                TB_Result.Text = TB_Input.Text;
                return;
            }

            _MainConvertor();
        }

        private void _MainConvertor()
        {
            switch (MySettings.ConvertFrom)
            {
                case enComputerSystems.Binary:
                    {
                        if (MySettings.ConvertTo == enComputerSystems.Octal)
                        {
                            TB_Result.Text = _ConvertBinaryToOctal(TB_Input.Text);
                        }
                        else if (MySettings.ConvertTo == enComputerSystems.Decimal)
                        {
                            TB_Result.Text = _ConvertBinaryToDecimal(TB_Input.Text).ToString();
                        }
                        else if (MySettings.ConvertTo == enComputerSystems.Hexadecimal)
                        {
                            TB_Result.Text = _ConvertBinaryToHexa(TB_Input.Text).ToString();
                        }
                        return;
                    }

                case enComputerSystems.Octal:
                    {
                        if (MySettings.ConvertTo == enComputerSystems.Binary)
                        {
                            TB_Result.Text = _ConvertOctalToBinary(TB_Input.Text);
                        }
                        else if (MySettings.ConvertTo == enComputerSystems.Decimal)
                        {
                            TB_Result.Text = _ConvertOctalToDecimal(TB_Input.Text).ToString();
                        }
                        else if (MySettings.ConvertTo == enComputerSystems.Hexadecimal)
                        {
                            TB_Result.Text = _ConvertOctalToHexa(TB_Input.Text);
                        }
                        return;
                    }

                case enComputerSystems.Decimal:
                    {
                        if (MySettings.ConvertTo == enComputerSystems.Binary)
                        {
                            TB_Result.Text = _ConvertDecimalToBinary(TB_Input.Text);
                        }
                        else if (MySettings.ConvertTo == enComputerSystems.Octal)
                        {
                            TB_Result.Text = _ConvertDecimalToOctal(TB_Input.Text);
                        }
                        else if (MySettings.ConvertTo == enComputerSystems.Hexadecimal)
                        {
                            TB_Result.Text = _ConvertDecimalToHexa(TB_Input.Text);
                            return;
                        }
                        return;
                    }

                case enComputerSystems.Hexadecimal:
                    {
                        if (MySettings.ConvertTo == enComputerSystems.Binary)
                        {
                            TB_Result.Text = _ConvertHexaToBinary(TB_Input.Text);
                        }
                        else if (MySettings.ConvertTo == enComputerSystems.Octal)
                        {
                            TB_Result.Text = _ConvertHexaToOctal(TB_Input.Text);
                        }
                        else if (MySettings.ConvertTo == enComputerSystems.Decimal)
                        {
                            TB_Result.Text = Convert.ToString(_ConvertHexaToDecimal(TB_Input.Text));
                        }
                        return;
                    }
            }
        }

        private int _ConvertBinaryToDecimal(String BinaryInput)
        {
            int DecimalNumber = 0;

            char[] ReverseTempArray = BinaryInput.ToCharArray();
            Array.Reverse(ReverseTempArray);
            BinaryInput = new string(ReverseTempArray);

            for (Byte i = 0; i < BinaryInput.Length; i++)
            {
                if (BinaryInput[i].Equals('1'))
                {
                    DecimalNumber += (int)Math.Pow(2, i);
                }
            }

            return DecimalNumber;
        }
        private String _ConvertDecimalToBinary(String DecimalInput)
        {
            int DecimalNumber = int.Parse(DecimalInput);

            String BinaryResult = String.Empty;

            while (DecimalNumber > 0)
            {
                if (DecimalNumber % 2 == 0)
                {
                    BinaryResult += '0';
                }
                else
                    BinaryResult += '1';

                DecimalNumber /= 2;
            }

            return BinaryResult;
        }
        private String _ConvertDecimalToHexa(String DecimalInput)
        {
            Double DecimalNumber = Double.Parse(DecimalInput);
            String HexaResult = String.Empty;

            while (true)
            {
                DecimalNumber /= 16;

                HexaResult += Hexadecimal_ArrElements[((int)((DecimalNumber - Math.Floor(DecimalNumber)) * 16))];

                DecimalNumber = Math.Floor(DecimalNumber);

                if (Math.Floor(DecimalNumber) == 0)
                {
                    break;
                }
            }

            char[] ReverseTempArray = HexaResult.ToCharArray();
            Array.Reverse(ReverseTempArray);
            HexaResult = new string(ReverseTempArray);

            return HexaResult;
        }
        private int _ConvertHexaToDecimal(String HexaInput)
        {
            int DecimalResult = 0;

            char HexaLetter;
            int HexaDigit;
            for (Byte i = 0; i < HexaInput.Length; i++)
            {
                HexaLetter = (HexaInput[HexaInput.Length - 1 - i]);
                HexaLetter = char.ToUpper(HexaLetter);

                HexaDigit = Array.IndexOf(Hexadecimal_ArrElements, HexaLetter);
                DecimalResult += Convert.ToInt32(HexaDigit * Math.Pow(16, i));
            }

            return DecimalResult;
        }
        private String _ConvertHexaToBinary(String HexaInput)
        {
            return _ConvertDecimalToBinary(_ConvertHexaToDecimal(HexaInput).ToString());
        }
        private String _ConvertBinaryToHexa(String BinaryInput)
        {
            return _ConvertDecimalToHexa(_ConvertBinaryToDecimal(BinaryInput).ToString()).ToString();
        }
        private int _ConvertOctalToDecimal(String OctalInput)
        {
            int DecimalResult = 0;

            char OctalDigit;
            int OctalNumber;

            for (Byte i = 0; i < OctalInput.Length; i++)
            {
                OctalDigit = char.ToUpper(OctalInput[OctalInput.Length - 1 - i]);
                OctalNumber = int.Parse(OctalDigit.ToString());


                DecimalResult += Convert.ToInt32(OctalNumber * Math.Pow(8, i));
            }

            return DecimalResult;
        }
        private String _ConvertOctalToBinary(String OctalInput)
        {
            return _ConvertDecimalToBinary(_ConvertOctalToDecimal(OctalInput).ToString());
        }
        private String _ConvertDecimalToOctal(String DecimalInput)
        {
            Double DecimalNumber = Double.Parse(DecimalInput);
            String OctalResult = String.Empty;

            while (true)
            {
                DecimalNumber /= 8;

                OctalResult += ((int)((DecimalNumber - Math.Floor(DecimalNumber)) * 8));

                DecimalNumber = Math.Floor(DecimalNumber);

                if (Math.Floor(DecimalNumber) == 0)
                {
                    break;
                }
            }

            char[] ReverseTempArray = OctalResult.ToCharArray();
            Array.Reverse(ReverseTempArray);
            OctalResult = new string(ReverseTempArray);

            return OctalResult;
        }
        private String _ConvertHexaToOctal(String HexaInput)
        {
            return _ConvertDecimalToOctal(_ConvertHexaToDecimal(HexaInput).ToString());
        }
        private String _ConvertOctalToHexa(String OctalInput)
        {
            return _ConvertDecimalToHexa(_ConvertOctalToDecimal(OctalInput).ToString());
        }
        private String _ConvertBinaryToOctal(String BinaryInput)
        {
            return _ConvertDecimalToOctal(_ConvertBinaryToDecimal(BinaryInput).ToString());
        }



        private void CB_ConvertFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySettings.ConvertFrom = (enComputerSystems)CB_ConvertFrom.SelectedIndex;
        }

        private void CB_ConvertTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySettings.ConvertTo = (enComputerSystems)CB_ConvertTo.SelectedIndex;
        }


        private void TB_Input_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {


            switch (MySettings.ConvertFrom)
            {

                case enComputerSystems.Binary:
                    {

                        if (!Regex.IsMatch(TB_Input.Text, @"^[10]+$") && !String.IsNullOrEmpty(TB_Input.Text))

                        {
                            e.Cancel = true;
                            errorProvider1.SetError(TB_Input, "Make Sure To Enter Correct Binary Form {0} Or {1}");
                        }
                        else
                        {
                            e.Cancel = false;
                            errorProvider1.SetError(TB_Input, "");
                        }

                        return;
                    }

                case enComputerSystems.Octal:
                    {
                        if (!Regex.IsMatch(TB_Input.Text, @"^[0-7]+$") && !String.IsNullOrEmpty(TB_Input.Text))
                        {
                            e.Cancel = true;
                            errorProvider1.SetError(TB_Input, "Make Sure To Enter Correct Octal Form {0} To {7}");
                        }
                        else
                        {
                            e.Cancel = false;
                            errorProvider1.SetError(TB_Input, "");
                        }
                        return;
                    }

                case enComputerSystems.Decimal:
                    {
                        if (!Regex.IsMatch(TB_Input.Text, @"^[0-9]+$") && !String.IsNullOrEmpty(TB_Input.Text))
                        {
                            e.Cancel = true;
                            errorProvider1.SetError(TB_Input, "Make Sure To Enter Correct Decimal Form {0} To {9}");
                        }
                        else
                        {
                            e.Cancel = false;
                            errorProvider1.SetError(TB_Input, "");
                        }
                        return;
                    }

                case enComputerSystems.Hexadecimal:
                    {

                        if (!Regex.IsMatch(TB_Input.Text, @"^(\d{0,}|[A-Fa-f]{0,}){0,}$", RegexOptions.Compiled) && !String.IsNullOrEmpty(TB_Input.Text))
                        {
                            e.Cancel = true;
                            errorProvider1.SetError(TB_Input, "Make Sure To Enter Correct Hexadecimal Form [0 - 9] And [A-F]");
                        }
                        else
                        {
                            e.Cancel = false;
                            errorProvider1.SetError(TB_Input, "");
                        }
                        return;
                    }
            }


        }
    }
}