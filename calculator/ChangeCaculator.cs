using apiPDV.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace apiPDV.calculator
{
    class ChangeCaculator
    {
        public string changeCaculator(double changep)
        {
            int valueTactical = 90;
            int valueAffected = 0;
            ArrayList change = new ArrayList();
            change.Add(valueTactical);

            ArrayList notesUnused = new ArrayList();

            for (double i = change.Count; change.IndexOf(0) > 0; i++)
            {
                if (change.IndexOf(0) >= 100)
                {
                    valueAffected = change.IndexOf(0);
                    valueAffected = valueAffected - 100;
                    change.Remove(0);
                    change.Add(valueAffected);
                    notesUnused.Add("100");
                    continue;
                }
                if (change.IndexOf(0) >= 50)
                {
                    valueAffected = change.IndexOf(0);
                    valueAffected = valueAffected - 50;
                    change.Remove(0);
                    change.Add(valueAffected);
                    notesUnused.Add("50");
                    continue;
                }

                if (change.IndexOf(0) >= 20)
                {
                    valueAffected = change.IndexOf(0);
                    valueAffected = valueAffected - 20;
                    change.Remove(0);
                    change.Add(valueAffected);
                    notesUnused.Add("20");
                    continue;
                }

                if (change.IndexOf(0) >= 10)
                {
                    valueAffected = change.IndexOf(0);
                    valueAffected = valueAffected - 10;
                    change.Remove(0);
                    change.Add(valueAffected);
                    notesUnused.Add("10");
                    continue;
                }
                if (change.IndexOf(0) >= 5)
                {
                    valueAffected = change.IndexOf(0);
                    valueAffected = valueAffected - 5;
                    change.Remove(0);
                    change.Add(valueAffected);
                    notesUnused.Add("5");
                    continue;
                }
            }
            return "As notas usadas " + notesUnused.ToArray();
        }
    }
}