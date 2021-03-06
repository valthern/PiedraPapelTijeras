// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
