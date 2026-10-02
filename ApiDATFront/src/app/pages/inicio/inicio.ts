import { Component, inject, signal } from '@angular/core';

import { DatosDatService } from '../../services/datos-dat';
import { PedidosSearsService } from '../../services/pedido-sears';

import { DatosDAT } from '../../models/datos-dat.model';
import { PedidoSears } from '../../models/pedido-sears-model';


type PedidoSeleccionado =
  '' |
  'sears' |
  'sanborns' |
  'dax';


type ApiSeleccionada =
  '' |
  'datos' |
  'sears';

type ApartadoSeleccionado =
'apartado1' |
'apartado2' |
'apartado3';


@Component({
  selector: 'app-inicio',
  imports: [],
  templateUrl: './inicio.html',
  styleUrl: './inicio.css'
})
export class Inicio {

  private readonly datosDATService =
    inject(DatosDatService);

  private readonly pedidosSearsService =
    inject(PedidosSearsService);


  pedidoSeleccionado =
    signal<PedidoSeleccionado>('');


  apiSeleccionada =
    signal<ApiSeleccionada>('');


  datos =
    signal<DatosDAT[]>([]);


  pedidosSears =
    signal<PedidoSears[]>([]);


  cargando =
    signal(false);


  error =
    signal('');

  apartadoSeleccionado = 
    signal<ApartadoSeleccionado>('apartado1');


  seleccionarPedido(pedido: string): void {

    this.pedidoSeleccionado.set(
      pedido as PedidoSeleccionado
    );

    this.apiSeleccionada.set('');

    this.datos.set([]);

    this.pedidosSears.set([]);

    this.error.set('');

    this.cargando.set(false);
  }


  seleccionarApi(api: string): void {

    this.apiSeleccionada.set(
      api as ApiSeleccionada
    );

    this.datos.set([]);

    this.pedidosSears.set([]);

    this.error.set('');

    if (api === '') {

      this.cargando.set(false);

      return;
    }

    this.cargando.set(true);


    if (api === 'datos') {

      this.datosDATService
        .obtenerDatos()
        .subscribe({

          next: (respuesta) => {

            this.datos.set(respuesta);

            this.cargando.set(false);
          },

          error: (error) => {

            console.error(
              'Error al obtener Datos DAT:',
              error
            );

            this.error.set(
              'No se pudieron obtener los datos.'
            );

            this.cargando.set(false);
          }

        });

      return;
    }


    if (api === 'sears') {

      this.pedidosSearsService
        .obtenerPedidos()
        .subscribe({

          next: (respuesta) => {

            this.pedidosSears.set(respuesta);

            this.cargando.set(false);
          },

          error: (error) => {

            console.error(
              'Error al obtener Pedidos Sears:',
              error
            );

            this.error.set(
              'No se pudieron obtener los pedidos Sears.'
            );

            this.cargando.set(false);
          }

        });

    }

  }


  volverInicio(): void {

    this.pedidoSeleccionado.set('');

    this.apiSeleccionada.set('');

    this.datos.set([]);

    this.pedidosSears.set([]);

    this.error.set('');

    this.cargando.set(false);
  }

  seleccionarApartado(apartado: ApartadoSeleccionado): void {
    this.apartadoSeleccionado.set(apartado);
  } 



}