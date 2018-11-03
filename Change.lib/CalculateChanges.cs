using System;

namespace Change.lib
{
    public class CalculateChanges
    {
        public int[] Banks = new int[] { 1000, 500, 100, 50, 20, 5, 1 };
        public ChangeModels Calculate(int pay, int amount)
        {
            var changeModels = new ChangeModels();
            changeModels.Change = pay - amount;
            var changeTemp = changeModels.Change;

            if (changeTemp >= Banks[0])
            {
                changeModels.Thounsand = changeTemp / Banks[0];
                DecreaseChange(changeModels.Thounsand, Banks[0],ref changeTemp);
            }
            if (changeTemp >= Banks[1])
            {
                changeModels.FiveHundred = changeTemp / Banks[1];
                DecreaseChange(changeModels.FiveHundred, Banks[1],ref changeTemp);
            }
            if (changeTemp >= Banks[2])
            {
                changeModels.OneHundred = changeTemp / Banks[2];
                DecreaseChange(changeModels.OneHundred, Banks[2],ref changeTemp);
            }
            if (changeTemp >= Banks[3])
            {
                changeModels.Fifty = changeTemp / Banks[3];
                DecreaseChange(changeModels.Fifty, Banks[3],ref changeTemp);
            }
            if (changeTemp >= Banks[4])
            {
                changeModels.Twenty = changeTemp / Banks[4];
                DecreaseChange(changeModels.Twenty, Banks[4],ref changeTemp);
            }
            if (changeTemp >= Banks[5])
            {
                changeModels.Five = changeTemp / Banks[5];
                DecreaseChange(changeModels.Five, Banks[5],ref changeTemp);
            }
            if (changeTemp >= Banks[6])
            {
                changeModels.One = changeTemp / Banks[6];
                DecreaseChange(changeModels.One, Banks[6],ref changeTemp);
            }

            return changeModels;
        }

        private void DecreaseChange(int bankValue, int bank,ref int changeTemp)
        {
            changeTemp -= bankValue * bank;
        }
    }
}