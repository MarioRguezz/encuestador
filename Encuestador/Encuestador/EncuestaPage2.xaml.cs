using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Encuestador
{
	public partial class EncuestaPage2 : ContentPage
	{

		//List<string> Items = new List<string>();
		//ObservableCollection<ListItem> CurrentItems = new ObservableCollection<ListItem>();
		//List<string> Casillas = new List<string>();
		//ObservableCollection<ListItem> CurrentCasillas = new ObservableCollection<ListItem>();

		//ObservableCollection<ListItem> Respuestas = new ObservableCollection<ListItem>();

		public EncuestaPage2()
		{
			InitializeComponent();

			//TestLista();

			var listaRelacionada = new ListaConRelacion();
			listaRelacionada.SetItems("EL TITULO",
			  	new List<string>()
				{
					"PREGUNTA 1",
				"PREGUNTA 2",
				"PREGUNTA 3",
				"PREGUNTA 4",
				},
				new List<string>()
				{
				"CASILLA 1",
				"CASILLA 2",
				"CASILLA 3",
				});

			_stack.Children.Add(listaRelacionada);

			var listaRelacionada2 = new ListaConRelacion();
			listaRelacionada2.SetItems("EL TITULO",
			  	new List<string>()
				{
					"PREGUNTA X",
				"PREGUNTA Y",
				"PREGUNTA Z",
				"PREGUNTA XY",
				},
				new List<string>()
				{
				"CASILLA N",
				"CASILLA R",
				"CASILLA M",
				});

			_stack.Children.Add(listaRelacionada2);

			var radioGroup = new RadioButtonGroup(new string[] { "P1", "P2", "P3" });
			radioGroup.Label.Text = "RADIOS";

			radioGroup.ItemSelected += (sender, e) =>
			{
				System.Diagnostics.Debug.WriteLine("RADIO SELECTED: {0} ID: {1}", radioGroup.Values[0], radioGroup.SelectedIndex);
			};


			_stack.Children.Add(radioGroup);

			var input = new OpcionInput();
			input.Label.Text = "TEXT INPUT OPTION";
			input.Entry.TextChanged += (sender, e) =>
			{
				System.Diagnostics.Debug.WriteLine("INPUT CHANGED: {0}",e.NewTextValue);
			};

			_stack.Children.Add(input);


			NavigationPage.SetHasNavigationBar(this, false);
		}

		void TestLista()
		{
			//_listItems.
			//_listItems.Label.Text = "ITEMS";

			//Items = new List<string>()
			//{
			//	"la pregunta bien largota largota largota largota largota largota largota largota largota largota largota ",
			//	"b",
			//	"c",
			//	"d",
			//	"e",
			//	"f",
			//};
			//CurrentItems = new ObservableCollection<ListItem>();
			//foreach (var item in Items)
			//	CurrentItems.Add(new ListItem() { Value = item });
			//_listItems.Values = CurrentItems;

			//_listCasillas.Label.Text = "CASILLAS";

			//Casillas = new List<string>()
			//{
			//	"la respuesta bien grandota grandota grandota grandota grandota grandota",
			//	"C2",
			//	"C3",
			//};
			//CurrentCasillas = new ObservableCollection<ListItem>();
			//foreach (var item in Casillas)
			//	CurrentCasillas.Add(new ListItem() { Value = item });
			//_listCasillas.Values = CurrentCasillas;

			//_listRespuestas.ItemsSource = Respuestas;

			//_listItems.ListView.ItemSelected += (sender, e) =>
			//{
			//	//System.Diagnostics.Debug.WriteLine("asd");
			//	if (e.SelectedItem == null)
			//		return;

			//	//System.Diagnostics.Debug.WriteLine("asd");
			//	if (_listCasillas.SelectedItem != null)
			//	{
			//		var x = _listItems.SelectedItem;
			//		var y = _listCasillas.SelectedItem;

			//		CurrentItems.Remove(x);
			//		CurrentCasillas.Remove(y);


			//		var z = x + " - " + y;
			//		Respuestas.Add(new ListItem()
			//		{
			//			Value = z,
			//		});

			//		_listItems.ListView.SelectedItem = null;
			//		_listCasillas.ListView.SelectedItem = null;
			//	}
			//};

			//_listItems.ListView.ItemTapped += (sender, e) =>
			//{
			//	if (_listItems.SelectedItem != null && (e.Item != null) && (e.Item == _listItems.SelectedItem))
			//	{

			//	}
			//};

			//_listCasillas.ListView.ItemSelected += (sender, e) =>
			//{

			//	if (e.SelectedItem == null)
			//		return;

			//	//System.Diagnostics.Debug.WriteLine("asd");
			//	if (_listItems.SelectedItem != null)
			//	{
			//		var x = _listItems.SelectedItem as ListItem;
			//		var y = _listCasillas.SelectedItem as ListItem;

			//		CurrentItems.Remove(x);
			//		CurrentCasillas.Remove(y);


			//		var z = x.Value + " - " + y.Value;
			//		Respuestas.Add(new ListItem()
			//		{
			//			Value = z,
			//		});

			//		_listItems.ListView.SelectedItem = null;
			//		_listCasillas.ListView.SelectedItem = null;
			//	}
			//};


			//_listRespuestas.ItemSelected += (sender, e) =>
			//{
			//	if (e.SelectedItem == null)
			//		return;
			//	_listRespuestas.SelectedItem = null;
			//};
		}

	}
}