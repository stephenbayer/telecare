using System;
using System.Collections.Generic;
using System.Text;

namespace Cars.Models
{
    public class Car : ICar
    {
        private double _price = 0;
        private String _color = "N/A";
        private int _safetyRating = 0;
        private Dictionary<String, Object> _options = new Dictionary<string, object>();

        public void SetPrice(double price)
        {
            _price = price;
        }
        public double GetPrice()
        {
           return _price;
        }

        public void SetSafetyRating(int safetyRating)
        {
            _safetyRating = safetyRating;
        }

        public void SetOptions(Dictionary<string, object> otherOptions)
        {
            if (otherOptions != null)
            {
                foreach (String key in otherOptions.Keys)
                {
                    _options[key] = otherOptions[key];
                }
            }
        }

        public void SetColor(string color)
        {
            _color = color;
        }

        public string GetColor()
        {
            return _color;
        }

        public int GetSafetyRating()
        {
            return _safetyRating;
        }

        public Object GetOption(string key)
        {
            return  _options.GetValueOrDefault(key);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Car - ");
            sb.AppendLine("Color: " + this.GetColor());
            sb.AppendLine("SafetyRating: " + this.GetSafetyRating());
            sb.AppendLine("Price: " + this.GetPrice());

            sb.AppendLine("Other Options:");
            foreach (String key in _options.Keys)
            {
                
                sb.AppendLine(key + ": " + _options[key]);
            }
            
            
            
            return sb.ToString();
        }
    }
}
