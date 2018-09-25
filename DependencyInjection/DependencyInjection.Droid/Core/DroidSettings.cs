using Android.Content;
using DependencyInjection.Core;

namespace DependencyInjection.Droid
{
    public class DroidSettings : ISettings
    {
        private readonly ISharedPreferences preferences;

        public DroidSettings(Context context)
        {
            preferences = context.GetSharedPreferences(context.PackageName, FileCreationMode.Private);
        }

        public bool IsSoundOn
        {
            get { return preferences.GetBoolean("IsSoundOn", true); }
            set
            {
                using (var editor = preferences.Edit())
                {
                    editor.PutBoolean("IsSoundOn", value);
                    editor.Commit();
                }
            }
        }
    }
}

