#pragma checksum "C:\Users\Omar\source\ejemplos\net5\PiedraPapelTijeras\PiedraPapelTijeras\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6986dd64485f3f44adf13940cb20914f6a91ad9"
// <auto-generated/>
#pragma warning disable 1591
namespace PiedraPapelTijeras.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Omar\source\ejemplos\net5\PiedraPapelTijeras\PiedraPapelTijeras\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Omar\source\ejemplos\net5\PiedraPapelTijeras\PiedraPapelTijeras\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Omar\source\ejemplos\net5\PiedraPapelTijeras\PiedraPapelTijeras\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Omar\source\ejemplos\net5\PiedraPapelTijeras\PiedraPapelTijeras\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Omar\source\ejemplos\net5\PiedraPapelTijeras\PiedraPapelTijeras\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Omar\source\ejemplos\net5\PiedraPapelTijeras\PiedraPapelTijeras\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Omar\source\ejemplos\net5\PiedraPapelTijeras\PiedraPapelTijeras\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Omar\source\ejemplos\net5\PiedraPapelTijeras\PiedraPapelTijeras\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Omar\source\ejemplos\net5\PiedraPapelTijeras\PiedraPapelTijeras\_Imports.razor"
using PiedraPapelTijeras;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Omar\source\ejemplos\net5\PiedraPapelTijeras\PiedraPapelTijeras\_Imports.razor"
using PiedraPapelTijeras.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Omar\source\ejemplos\net5\PiedraPapelTijeras\PiedraPapelTijeras\Pages\Index.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Piedra, Papel y Tijeras</h1>");
#nullable restore
#line 9 "C:\Users\Omar\source\ejemplos\net5\PiedraPapelTijeras\PiedraPapelTijeras\Pages\Index.razor"
 if (!string.IsNullOrEmpty(resultadoMensaje))
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "h3");
            __builder.AddAttribute(2, "style", "color:" + " " + (
#nullable restore
#line 11 "C:\Users\Omar\source\ejemplos\net5\PiedraPapelTijeras\PiedraPapelTijeras\Pages\Index.razor"
                       resultadoMensajeColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(3, 
#nullable restore
#line 11 "C:\Users\Omar\source\ejemplos\net5\PiedraPapelTijeras\PiedraPapelTijeras\Pages\Index.razor"
                                               resultadoMensaje

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 12 "C:\Users\Omar\source\ejemplos\net5\PiedraPapelTijeras\PiedraPapelTijeras\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "btn btn-info");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\Omar\source\ejemplos\net5\PiedraPapelTijeras\PiedraPapelTijeras\Pages\Index.razor"
                                       Reiniciar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(7, "Reiniciar");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "style", "display: flex; justify-content: center; margin-bottom: 20px;");
            __builder.OpenElement(11, "img");
            __builder.AddAttribute(12, "src", 
#nullable restore
#line 17 "C:\Users\Omar\source\ejemplos\net5\PiedraPapelTijeras\PiedraPapelTijeras\Pages\Index.razor"
               jugadaOponente.Imagen

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(13, "alt", "Imagen");
            __builder.AddAttribute(14, "class", "imagen");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "style", "display:flex; justify-content:space-around;");
#nullable restore
#line 21 "C:\Users\Omar\source\ejemplos\net5\PiedraPapelTijeras\PiedraPapelTijeras\Pages\Index.razor"
     foreach (var jugada in jugadas)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "img");
            __builder.AddAttribute(19, "src", 
#nullable restore
#line 23 "C:\Users\Omar\source\ejemplos\net5\PiedraPapelTijeras\PiedraPapelTijeras\Pages\Index.razor"
                   jugada.Imagen

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(20, "class", "imagen imagen-seleccionable");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\Omar\source\ejemplos\net5\PiedraPapelTijeras\PiedraPapelTijeras\Pages\Index.razor"
                                                                                  () => SeleccionarJugada(jugada)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 24 "C:\Users\Omar\source\ejemplos\net5\PiedraPapelTijeras\PiedraPapelTijeras\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\Omar\source\ejemplos\net5\PiedraPapelTijeras\PiedraPapelTijeras\Pages\Index.razor"
       
    List<Jugada> jugadas = new List<Jugada>()
    {
        new Jugada{Imagen="piedra.jpg",OptionPPT=OptionPPT.Piedra,VenceA=OptionPPT.Tijera,PierdeContra=OptionPPT.Papel },
        new Jugada{Imagen="tijeras.jpg",OptionPPT=OptionPPT.Tijera,VenceA=OptionPPT.Papel,PierdeContra=OptionPPT.Piedra},
        new Jugada{Imagen="papel.jpg",OptionPPT=OptionPPT.Papel,VenceA=OptionPPT.Piedra,PierdeContra=OptionPPT.Tijera}
    };

    Jugada jugadaOponente;
    string resultadoMensaje;
    string resultadoMensajeColor;
    Timer timer;

    protected override void OnInitialized()
    {
        jugadaOponente = jugadas[0];
        timer = new Timer();
        timer.Interval = 100;
        timer.Elapsed += TimerOnElapsed;
        timer.Start();
    }

    private void Reiniciar()
    {
        timer.Start();
        resultadoMensaje = null;
        resultadoMensajeColor = null;
    }

    private void SeleccionarJugada(Jugada jugada)
    {
        timer.Stop();
        var resultado = jugada.JugarContra(jugadaOponente);

        if (resultado == EstatusJuego.Victoria)
        {
            resultadoMensaje = "Ganaste!";
            resultadoMensajeColor = "green";
        }
        else if(resultado == EstatusJuego.Derrota)
        {
            resultadoMensaje = "Perdiste!";
            resultadoMensajeColor = "red";
        }
        else
        {
            resultadoMensaje = "Empate!";
            resultadoMensajeColor = "black";
        }
    }

    int indiceJugadaOponente = 0;

    private void TimerOnElapsed(object sender, ElapsedEventArgs e)
    {
        indiceJugadaOponente = (indiceJugadaOponente + 1) % jugadas.Count;
        jugadaOponente = jugadas[indiceJugadaOponente];
        StateHasChanged();
    }

    class Jugada
    {
        public OptionPPT OptionPPT { get; set; }
        public OptionPPT VenceA { get; set; }
        public OptionPPT PierdeContra { get; set; }
        public string Imagen { get; set; }

        public EstatusJuego JugarContra(Jugada jugada2)
        {
            if (OptionPPT == jugada2.OptionPPT)
            {
                return EstatusJuego.Empate;
            }

            if (VenceA == jugada2.OptionPPT)
            {
                return EstatusJuego.Victoria;
            }

            return EstatusJuego.Derrota;
        }
    }

    enum OptionPPT { Piedra, Papel, Tijera }

    enum EstatusJuego { Victoria, Derrota, Empate }

    public void Dispose()
    {
        if (timer != null)
        {
            timer.Dispose();
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
