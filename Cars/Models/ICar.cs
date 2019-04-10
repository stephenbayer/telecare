using System;
using System.Collections.Generic;
using System.Text;

namespace Cars.Models
{
    public interface ICar
    {
        Double GetPrice();
        String GetColor();
        int GetSafetyRating();
        Object GetOption(string key);
    }
}
