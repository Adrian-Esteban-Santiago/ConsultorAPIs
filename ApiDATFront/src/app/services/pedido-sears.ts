import { inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

import { PedidoSears } from '../models/pedido-sears-model';

@Injectable({
providedIn: 'root'
})
export class PedidosSearsService {

private readonly http = inject(HttpClient);

private readonly apiUrl =
    'http://localhost:5079/api/PedidosSears';

obtenerPedidos(): Observable<PedidoSears[]> {

    return this.http.get<PedidoSears[]>(this.apiUrl);

}
}