using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Reflection;

namespace JobProfile
{
    public static class ResourceHelper
    {
        static Dictionary<string, int> resourceDictionary = new Dictionary<string, int>();
        public static int TranslateDrawable(string name)
        {
            int resourceValue = -1;
            switch (name)
            {
                case "adam":
                    {
                        resourceValue = Resource.Drawable.adam;
                        break;
                    }
                case "Hubbar":
                    {
                        resourceValue = Resource.Drawable.Hubbard;
                        break;
                    }
                case "name":
                    {
                        resourceValue = Resource.Drawable.Messi;
                        break;
                    }
                case "Nathan":
                    {
                        resourceValue = Resource.Drawable.Nathan;
                        break;
                    }
            }
            return resourceValue;
        }
        public static int TranslateDrawableWithReflection(string name)
        {
            int resourceValue = -1;
            if (resourceDictionary.ContainsKey(name))
            {
                resourceValue = resourceDictionary[name];
            }
            else
            {
                Type drawableType = typeof(Resource.Drawable);
                FieldInfo resourceFileInfo = drawableType.GetField(name);
                resourceValue = (int)resourceFileInfo.GetValue(null);
                resourceDictionary.Add(name, resourceValue);
            }
            return resourceValue;
        }
    }
}