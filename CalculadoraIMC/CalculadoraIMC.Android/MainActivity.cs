usando el  sistema ;

usando  Android . Aplicación ;
usando  Android . Contenido . PM ;
usando  Android . Tiempo de ejecución ;
usando  Android . Vistas ;
usando  Android . Widget ;
usando  Android . OS ;

espacio de nombres  CalculadoraIMC . Droide
{
    [ Actividad ( Etiqueta  =  " CalculadoraIMC " , Icon  =  " @ mipmap / icon " , Theme  =  " @ style / MainTheme " , MainLauncher  =  true , ConfigurationChanges  =  ConfigChanges . ScreenSize  |  ConfigChanges . Orientation )]
     clase  pública MainActivity : global :: Xamarin . Formularios . Plataforma . Android . FormsAppCompatActivity
    {
        protected  override  void  OnCreate ( Bundle  SavedInstanceState )
        {
            TabLayoutResource  =  Recurso . Disposición . Tabbar ;
            ToolbarResource  =  Recurso . Disposición . Barra de herramientas ;

            base . OnCreate ( SavedInstanceState );

            Xamarin . Esenciales . Plataforma . Init ( esto , SavedInstanceState );
            global :: Xamarin . Formularios . Formularios . Init ( esto , SavedInstanceState );
            global :: Xamarin . Formularios . FormsMaterial . Init ( esto , SavedInstanceState );
            LoadApplication ( nueva  aplicación ());
        }
        public  override  void  OnRequestPermissionsResult ( int  requestCode , string [] permisos , [ GeneratedEnum ] Android . Content . PM . Permission [] grantResults )
        {
            Xamarin . Esenciales . Plataforma . OnRequestPermissionsResult ( requestCode , permisos , grantResults );

            base . OnRequestPermissionsResult ( requestCode , permisos , grantResults );
        }
    }
}