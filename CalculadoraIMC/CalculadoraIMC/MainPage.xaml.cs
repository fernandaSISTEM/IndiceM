usando el  sistema ;
utilizando  System . Colecciones . Genérico ;
utilizando  System . ComponentModel ;
utilizando  System . Linq ;
utilizando  System . Texto ;
utilizando  System . Enhebrado . Tareas ;
usando  Xamarin . Formularios ;

espacio de nombres  CalculadoraIMC
{
    // Obtenga más información sobre cómo hacer visible el código personalizado en la vista previa de Xamarin.Forms
    // visitando https://aka.ms/xamarinforms-previewer
    [ DesignTimeVisible ( falso )]
     MainPage de clase parcial  pública : ContentPage 
    {
         MainPage pública ()
        {
            InitializeComponent ();
        }

        Private  void  Button_Clicked ( remitente del objeto  , EventArgs e ) 
        {
            if ( ! string . IsNullOrEmpty ( Altura . Text ) && 
                ! cuerda . IsNullOrEmpty ( Peso . Texto ))
            {
                var  altura  =  doble . Parse ( Altura . Texto );
                var  peso  =  doble . Parse ( Peso . Texto );

                var  imc  =  peso  / ( altura  *  altura );
                IMC . Texto  =  imc . ToString ();

                cadena  resultado  =  " " ;

                si ( imc  <  18 . 5 )
                {
                    resultado  =  " Tienes bajo peso " ;
                }
                más  si ( imc  > =  18 . 5  &&  imc  <=  24 . 9 )
                {
                    resultado  =  " Tu peso es normal " ;
                }
                más  si ( imc  > =  25  &&  imc  <=  29 . 9 )
                {
                    resultado  =  " Tienes sobrepreso " ;
                }
                demás
                {
                    resultado  =  " Tienes obesidad, ¡Cuídate! " ;
                }

                DisplayAlert ( " Resultado " , resultado , " Ok " );
            }
            demás
            {
                DisplayAlert ( " Datos erróneos " ,
                    " Por favor, llena toda la información " ,
                    " Ok " );
            }
           
        }
    }
}