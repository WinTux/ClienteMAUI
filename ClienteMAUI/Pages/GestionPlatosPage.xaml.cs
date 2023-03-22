using ClienteMAUI.ConexionDatos;
using ClienteMAUI.Models;

namespace ClienteMAUI.Pages;

public partial class GestionPlatosPage : ContentPage
{
    private readonly IRestConexionDatos conexionDatos;
	private Plato _plato;
	private bool _esNuevo;//si el plato es nuevo
	public Plato plato {
		get => _plato;
		set {
			_esNuevo = esNuevo(value);
			_plato = value;
			OnPropertyChanged();//Obligatorio al actualizar un plato existente
			//Nos toca: Manejo de los parámetros que se envían desde MainPage
		}
	}
    public GestionPlatosPage(IRestConexionDatos conexionDatos)
	{
		InitializeComponent();
		this.conexionDatos = conexionDatos;
		BindingContext = this;//Para enlazar datod de C# a xaml (es obligatorio)
	}
	bool esNuevo(Plato plato) {
		return plato.Id == 0 ? true : false;
	}
}