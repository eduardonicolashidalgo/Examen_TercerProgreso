using Newtonsoft.Json;
using Examen_TercerProgreso.Models;
namespace Examen_TercerProgreso.Views;

public partial class Detector_NH : ContentPage
{
	public Detector_NH()
	{
		InitializeComponent();
	}

	public async void Button_Clicked(object sender, EventArgs e)
	{
		var request = new HttpRequestMessage();
		request.RequestUri = new Uri("https://api-cepalstat.cepal.org/apispec_1.json");
		request.Method = HttpMethod.Get;
		request.Headers.Add("Accept", "aplication/json");

		var client = new HttpClient();
		HttpResponseMessage response = await client.SendAsync(request);
		if (response.StatusCode == System.Net.HttpStatusCode.OK)
		{ 
			String content = await response .Content.ReadAsStringAsync();
			var resultado = JsonConvert.DeserializeObject<List<DetectorModel>>(content);
			Lista.ItemsSource = resultado;
		}
	}
}