using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleForms
{
    public partial class Form1 : Form
    {
        private readonly HttpClient _httpClient;

        public Form1()
        {
            InitializeComponent();
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:5172")
            };
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            string inputText = txtInput.Text;

            if (string.IsNullOrWhiteSpace(inputText))
            {
                MessageBox.Show("Please enter some text.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var simpleObject = new { text = inputText };

            try
            {
                var jsonContent = new StringContent(JsonSerializer.Serialize(simpleObject), Encoding.UTF8, "application/json");
                HttpResponseMessage response = await _httpClient.PostAsync("/api/SimpleObject/create", jsonContent);

                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    txtResponse.Text = $"Success:\n{responseData}";
                }
                else
                {
                    string error = await response.Content.ReadAsStringAsync();
                    txtResponse.Text = $"Error:\n{response.StatusCode} - {error}";
                }
            }
            catch (Exception ex)
            {
                txtResponse.Text = $"Exception:\n{ex.Message}";
            }
        }

        private async void btnGetAll_Click(object sender, EventArgs e)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync("/api/SimpleObject/getAll");

                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    var simpleObjects = JsonSerializer.Deserialize<List<ObjectDto>>(responseData, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    txtResponse.Text = "All SimpleObjects:\n";
                    foreach (var obj in simpleObjects)
                    {
                        txtResponse.AppendText($"ID: {obj.Id}, Text: {obj.Text}\n");
                    }
                }
                else
                {
                    string error = await response.Content.ReadAsStringAsync();
                    txtResponse.Text = $"Error:\n{response.StatusCode} - {error}";
                }
            }
            catch (Exception ex)
            {
                txtResponse.Text = $"Exception:\n{ex.Message}";
            }
        }
    }

    internal class ObjectDto
    {
        public int Id { get; set; }
        public string Text { get; set; }
    }
}
