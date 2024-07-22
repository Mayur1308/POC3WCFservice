using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibraryPOC3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    
    public class Service1 : IService1
    {
        public void CreateStringKey(string keyName, string value)
        {
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("SOFTWARE\\Blob\\POCs");
            key.SetValue(keyName, value);
            key.Close();
        }

        public void CreateDwordKey(string keyName, int value)
        {
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("SOFTWARE\\Blob\\POCs");
            key.SetValue(keyName, value, RegistryValueKind.DWord);
            key.Close();
        }

        public void DeleteKey(string keyName)
        {
            using (var key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\Blob\\POCs", true))
            {
                if (key != null)
                {
                    var namesArray = key.GetValueNames();
                    foreach (string valueName in namesArray)
                    {
                        if (keyName == valueName)
                            key.DeleteValue(valueName);
                    }
                }
                key.Close();
            }
        }

        public void ModifyStringKey(string keyName, string value)
        {
            var key = Microsoft.Win32.Registry.LocalMachine;
            var subkey = key.OpenSubKey("Software\\Blob\\POCs", true);
            subkey.SetValue(keyName, value);
            key.Close();
            subkey.Close();
        }

        public void ModifyDwordKey(string keyName, int value)
        {
            var key = Microsoft.Win32.Registry.LocalMachine;
            var subkey = key.OpenSubKey("Software\\Blob\\POCs", true);
            subkey.SetValue(keyName, value, RegistryValueKind.DWord);
            key.Close();
            subkey.Close();
        }

        public object ReadKeyFromRegistry(string keyName)
        {
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey("Software\\Blob\\POCs", true))
            {
                if (key != null)
                {
                    object value = key.GetValue(keyName);
                    return value;
                }
            }
            return "";
        }

    }
}
