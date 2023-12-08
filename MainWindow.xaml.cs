using System;
using System.Collections.Generic;
using System.Windows;
using Newtonsoft.Json.Linq;

namespace JsonSearchApp
{
    public partial class MainWindow : Window
    {
        private readonly Dictionary<string, List<string>> jsonData = new Dictionary<string, List<string>>
        {
            { "8195", new List<string> { "Compliance_Policies" } },
            { "8197", new List<string> { "Resource_Access_Policies" } },
            { "8199", new List<string> { "Compliance_Policies, Resource_Access_Policies" } },
            { "8201", new List<string> { "Device_Configuration" } },
            { "8203", new List<string> { "Compliance_Policies, Device_Configuration" } },
            { "8205", new List<string> { "Device_Configuration, Resource_Access_Policies" } },
            { "8207", new List<string> { "Compliance_Policies, Device_Configuration, Resource_Access_Policies" } },
            { "8209", new List<string> { "Windows_Update_Policies" } },
            { "8211", new List<string> { "Compliance_Policies, Windows_Update_Policies" } },
            { "8213", new List<string> { "Resource_Access_Policies, Windows_Update_Policies" } },
            { "8215", new List<string> { "Compliance_Policies, Resource_Access_Policies, Windows_Update_Policies" } },
            { "8217", new List<string> { "Device_Configuration, Windows_Update_Policies" } },
            { "8219", new List<string> { "Compliance_Policies, Device_Configuration, Windows_Update_Policies" } },
            { "8221", new List<string> { "Device_Configuration, Resource_Access_Policies, Windows_Update_Policies" } },
            { "8223", new List<string> { "Compliance_Policies, Device_Configuration, Resource_Access_Policies, Windows_Update_Policies" } },
            { "8257", new List<string> { "Client_Apps" } },
            { "8259", new List<string> { "Client_Apps, Compliance_Policies" } },
            { "8261", new List<string> { "Client_Apps, Resource_Access_Policies" } },
            { "8263", new List<string> { "Client_Apps, Compliance_Policies, Resource_Access_Policies" } },
            { "8265", new List<string> { "Client_Apps, Device_Configuration" } },
            { "8267", new List<string> { "Client_Apps, Compliance_Policies, Device_Configuration" } },
            { "8269", new List<string> { "Client_Apps, Device_Configuration, Resource_Access_Policies" } },
            { "8271", new List<string> { "Client_Apps, Compliance_Policies, Device_Configuration, Resource_Access_Policies" } },
            { "8273", new List<string> { "Client_Apps, Windows_Update_Policies" } },
            { "8275", new List<string> { "Client_Apps, Compliance_Policies, Windows_Update_Policies" } },
            { "8277", new List<string> { "Client_Apps, Resource_Access_Policies, Windows_Update_Policies" } },
            { "8279", new List<string> { "Client_Apps, Compliance_Policies, Resource_Access_Policies, Windows_Update_Policies" } },
            { "8281", new List<string> { "Client_Apps, Device_Configuration, Windows_Update_Policies" } },
            { "8283", new List<string> { "Client_Apps, Compliance_Policies, Device_Configuration, Windows_Update_Policies" } },
            { "8285", new List<string> { "Client_Apps, Device_Configuration, Resource_Access_Policies, Windows_Update_Policies" } },
            { "8287", new List<string> { "Client_Apps, Compliance_Policies, Device_Configuration, Resource_Access_Policies, Windows_Update_Policies" } },
            { "8321", new List<string> { "Office_Click2Run_Apps" } },
            { "8323", new List<string> { "Compliance_Policies, Office_Click2Run_Apps" } },
            { "8325", new List<string> { "Office_Click2Run_Apps, Resource_Access_Policies" } },
            { "8327", new List<string> { "Compliance_Policies, Office_Click2Run_Apps, Resource_Access_Policies" } },
            { "8329", new List<string> { "Device_Configuration, Office_Click2Run_Apps" } },
            { "8331", new List<string> { "Compliance_Policies, Device_Configuration, Office_Click2Run_Apps" } },
            { "8333", new List<string> { "Device_Configuration, Office_Click2Run_Apps, Resource_Access_Policies" } },
            { "8335", new List<string> { "Compliance_Policies, Device_Configuration, Office_Click2Run_Apps, Resource_Access_Policies" } },
            { "8337", new List<string> { "Office_Click2Run_Apps, Windows_Update_Policies" } },
            { "8339", new List<string> { "Compliance_Policies, Office_Click2Run_Apps, Windows_Update_Policies" } },
            { "8341", new List<string> { "Office_Click2Run_Apps, Resource_Access_Policies, Windows_Update_Policies" } },
            { "8343", new List<string> { "Compliance_Policies, Office_Click2Run_Apps, Resource_Access_Policies, Windows_Update_Policies" } },
            { "8345", new List<string> { "Device_Configuration, Office_Click2Run_Apps, Windows_Update_Policies" } },
            { "8347", new List<string> { "Compliance_Policies, Device_Configuration, Office_Click2Run_Apps, Windows_Update_Policies" } },
            { "8349", new List<string> { "Device_Configuration, Office_Click2Run_Apps, Resource_Access_Policies, Windows_Update_Policies" } },
            { "8351", new List<string> { "Compliance_Policies, Device_Configuration, Office_Click2Run_Apps, Resource_Access_Policies, Windows_Update_Policies" } },
            { "8385", new List<string> { "Client_Apps, Office_Click2Run_Apps" } },
            { "8387", new List<string> { "Client_Apps, Compliance_Policies, Office_Click2Run_Apps" } },
            { "8389", new List<string> { "Client_Apps, Office_Click2Run_Apps, Resource_Access_Policies" } },
            { "8391", new List<string> { "Client_Apps, Compliance_Policies, Office_Click2Run_Apps, Resource_Access_Policies" } },
            { "8393", new List<string> { "Client_Apps, Device_Configuration, Office_Click2Run_Apps" } },
            { "8395", new List<string> { "Client_Apps, Compliance_Policies, Device_Configuration, Office_Click2Run_Apps" } },
            { "8397", new List<string> { "Client_Apps, Device_Configuration, Office_Click2Run_Apps, Resource_Access_Policies" } },
            { "8399", new List<string> { "Client_Apps, Compliance_Policies, Device_Configuration, Office_Click2Run_Apps, Resource_Access_Policies" } },
            { "8401", new List<string> { "Client_Apps, Office_Click2Run_Apps, Windows_Update_Policies" } },
            { "8403", new List<string> { "Client_Apps, Compliance_Policies, Office_Click2Run_Apps, Windows_Update_Policies" } },
            { "8405", new List<string> { "Client_Apps, Office_Click2Run_Apps, Resource_Access_Policies, Windows_Update_Policies" } },
            { "8407", new List<string> { "Client_Apps, Compliance_Policies, Office_Click2Run_Apps, Resource_Access_Policies, Windows_Update_Policies" } },
            { "8409", new List<string> { "Client_Apps, Device_Configuration, Office_Click2Run_Apps, Windows_Update_Policies" } },
            { "8411", new List<string> { "Client_Apps, Compliance_Policies, Device_Configuration, Office_Click2Run_Apps, Windows_Update_Policies" } },
            { "8413", new List<string> { "Client_Apps, Device_Configuration, Office_Click2Run_Apps, Resource_Access_Policies, Windows_Update_Policies" } },
            { "8415", new List<string> { "Client_Apps, Compliance_Policies, Device_Configuration, Office_Click2Run_Apps, Resource_Access_Policies, Windows_Update_Policies" } },
            { "12321", new List<string> { "Endpoint_Protection" } },
            { "12323", new List<string> { "Compliance_Policies, Endpoint_Protection" } },
            { "12325", new List<string> { "Endpoint_Protection, Resource_Access_Policies" } },
            { "12327", new List<string> { "Compliance_Policies, Endpoint_Protection, Resource_Access_Policies" } },
            { "12329", new List<string> { "Device_Configuration, Endpoint_Protection" } },
            { "12331", new List<string> { "Compliance_Policies, Device_Configuration, Endpoint_Protection" } },
            { "12333", new List<string> { "Device_Configuration, Endpoint_Protection, Resource_Access_Policies" } },
            { "12335", new List<string> { "Compliance_Policies, Device_Configuration, Endpoint_Protection, Resource_Access_Policies" } },
            { "12337", new List<string> { "Endpoint_Protection, Windows_Update_Policies" } },
            { "12339", new List<string> { "Compliance_Policies, Endpoint_Protection, Windows_Update_Policies" } },
            { "12341", new List<string> { "Endpoint_Protection, Resource_Access_Policies, Windows_Update_Policies" } },
            { "12343", new List<string> { "Compliance_Policies, Endpoint_Protection, Resource_Access_Policies, Windows_Update_Policies" } },
            { "12345", new List<string> { "Device_Configuration, Endpoint_Protection, Windows_Update_Policies" } },
            { "12347", new List<string> { "Compliance_Policies, Device_Configuration, Endpoint_Protection, Windows_Update_Policies" } },
            { "12349", new List<string> { "Device_Configuration, Endpoint_Protection, Resource_Access_Policies, Windows_Update_Policies" } },
            { "12351", new List<string> { "Compliance_Policies, Device_Configuration, Endpoint_Protection, Resource_Access_Policies, Windows_Update_Policies" } },
            { "12385", new List<string> { "Client_Apps, Endpoint_Protection" } },
            { "12387", new List<string> { "Client_Apps, Compliance_Policies, Endpoint_Protection" } },
            { "12389", new List<string> { "Client_Apps, Endpoint_Protection, Resource_Access_Policies" } },
            { "12391", new List<string> { "Client_Apps, Compliance_Policies, Endpoint_Protection, Resource_Access_Policies" } },
            { "12393", new List<string> { "Client_Apps, Device_Configuration, Endpoint_Protection" } },
            { "12395", new List<string> { "Client_Apps, Compliance_Policies, Device_Configuration, Endpoint_Protection" } },
            { "12397", new List<string> { "Client_Apps, Device_Configuration, Endpoint_Protection, Resource_Access_Policies" } },
            { "12399", new List<string> { "Client_Apps, Compliance_Policies, Device_Configuration, Endpoint_Protection, Resource_Access_Policies" } },
            { "12401", new List<string> { "Client_Apps, Endpoint_Protection, Windows_Update_Policies" } },
            { "12403", new List<string> { "Client_Apps, Compliance_Policies, Endpoint_Protection, Windows_Update_Policies" } },
            { "12405", new List<string> { "Client_Apps, Endpoint_Protection, Resource_Access_Policies, Windows_Update_Policies" } },
            { "12407", new List<string> { "Client_Apps, Compliance_Policies, Endpoint_Protection, Resource_Access_Policies, Windows_Update_Policies" } },
            { "12409", new List<string> { "Client_Apps, Device_Configuration, Endpoint_Protection, Windows_Update_Policies" } },
            { "12411", new List<string> { "Client_Apps, Compliance_Policies, Device_Configuration, Endpoint_Protection, Windows_Update_Policies" } },
            { "12413", new List<string> { "Client_Apps, Device_Configuration, Endpoint_Protection, Resource_Access_Policies, Windows_Update_Policies" } },
            { "12415", new List<string> { "Client_Apps, Compliance_Policies, Device_Configuration, Endpoint_Protection, Resource_Access_Policies, Windows_Update_Policies" } },
            { "12449", new List<string> { "Endpoint_Protection, Office_Click2Run_Apps" } },
            { "12451", new List<string> { "Compliance_Policies, Endpoint_Protection, Office_Click2Run_Apps" } },
            { "12453", new List<string> { "Endpoint_Protection, Office_Click2Run_Apps, Resource_Access_Policies" } },
            { "12455", new List<string> { "Compliance_Policies, Endpoint_Protection, Office_Click2Run_Apps, Resource_Access_Policies" } },
            { "12457", new List<string> { "Device_Configuration, Endpoint_Protection, Office_Click2Run_Apps" } },
            { "12459", new List<string> { "Compliance_Policies, Device_Configuration, Endpoint_Protection, Office_Click2Run_Apps" } },
            { "12461", new List<string> { "Device_Configuration, Endpoint_Protection, Office_Click2Run_Apps, Resource_Access_Policies" } },
            { "12463", new List<string> { "Compliance_Policies, Device_Configuration, Endpoint_Protection, Office_Click2Run_Apps, Resource_Access_Policies" } },
            { "12465", new List<string> { "Endpoint_Protection, Office_Click2Run_Apps, Windows_Update_Policies" } },
            { "12467", new List<string> { "Compliance_Policies, Endpoint_Protection, Office_Click2Run_Apps, Windows_Update_Policies" } },
            { "12469", new List<string> { "Endpoint_Protection, Office_Click2Run_Apps, Resource_Access_Policies, Windows_Update_Policies" } },
            { "12471", new List<string> { "Compliance_Policies, Endpoint_Protection, Office_Click2Run_Apps, Resource_Access_Policies, Windows_Update_Policies" } },
            { "12473", new List<string> { "Device_Configuration, Endpoint_Protection, Office_Click2Run_Apps, Windows_Update_Policies" } },
            { "12475", new List<string> { "Compliance_Policies, Device_Configuration, Endpoint_Protection, Office_Click2Run_Apps, Windows_Update_Policies" } },
            { "12477", new List<string> { "Device_Configuration, Endpoint_Protection, Office_Click2Run_Apps, Resource_Access_Policies, Windows_Update_Policies" } },
            { "12479", new List<string> { "Compliance_Policies, Device_Configuration, Endpoint_Protection, Office_Click2Run_Apps, Resource_Access_Policies, Windows_Update_Policies" } },
            { "12513", new List<string> { "Client_Apps, Endpoint_Protection, Office_Click2Run_Apps" } },
            { "12515", new List<string> { "Client_Apps, Compliance_Policies, Endpoint_Protection, Office_Click2Run_Apps" } },
            { "12517", new List<string> { "Client_Apps, Endpoint_Protection, Office_Click2Run_Apps, Resource_Access_Policies" } },
            { "12519", new List<string> { "Client_Apps, Compliance_Policies, Endpoint_Protection, Office_Click2Run_Apps, Resource_Access_Policies" } },
            { "12521", new List<string> { "Client_Apps, Device_Configuration, Endpoint_Protection, Office_Click2Run_Apps" } },
            { "12523", new List<string> { "Client_Apps, Compliance_Policies, Device_Configuration, Endpoint_Protection, Office_Click2Run_Apps" } },
            { "12525", new List<string> { "Client_Apps, Device_Configuration, Endpoint_Protection, Office_Click2Run_Apps, Resource_Access_Policies" } },
            { "12527", new List<string> { "Client_Apps, Compliance_Policies, Device_Configuration, Endpoint_Protection, Office_Click2Run_Apps, Resource_Access_Policies" } },
            { "12529", new List<string> { "Client_Apps, Endpoint_Protection, Office_Click2Run_Apps, Windows_Update_Policies" } },
            { "12531", new List<string> { "Client_Apps, Compliance_Policies, Endpoint_Protection, Office_Click2Run_Apps, Windows_Update_Policies" } },
            { "12533", new List<string> { "Client_Apps, Endpoint_Protection, Office_Click2Run_Apps, Resource_Access_Policies, Windows_Update_Policies" } },
            { "12535", new List<string> { "Client_Apps, Compliance_Policies, Endpoint_Protection, Office_Click2Run_Apps, Resource_Access_Policies, Windows_Update_Policies" } },
            { "12537", new List<string> { "Client_Apps, Device_Configuration, Endpoint_Protection, Office_Click2Run_Apps, Windows_Update_Policies" } },
            { "12539", new List<string> { "Client_Apps, Compliance_Policies, Device_Configuration, Endpoint_Protection, Office_Click2Run_Apps, Windows_Update_Policies" } },
            { "12541", new List<string> { "Client_Apps, Device_Configuration, Endpoint_Protection, Office_Click2Run_Apps, Resource_Access_Policies, Windows_Update_Policies" } },
            { "12543", new List<string> { "Client_Apps, Compliance_Policies, Device_Configuration, Endpoint_Protection, Office_Click2Run_Apps, Resource_Access_Policies, Windows_Update_Policies" } },
        };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string code = codeTextBox.Text.Trim();

            if (jsonData.ContainsKey(code))
            {
                List<string> values = jsonData[code];
                string result = $"Code: {code}\nContents: {string.Join(", ", values)}";
                resultTextBox.Text = result;
            }
            else
            {
                resultTextBox.Text = "Code not found!";
            }
        }
    }
}
