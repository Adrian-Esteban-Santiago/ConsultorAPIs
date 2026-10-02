import { inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { DatosDAT } from '../models/datos-dat.model';

@Injectable({
providedIn: 'root'
})
export class DatosDatService{
    private readonly http = inject(HttpClient);
    private readonly apiUrl= 'http://localhost:5079/api/DatosDAT';
    
    obtenerDatos(): Observable<DatosDAT[]> {
    return this.http.get<DatosDAT[]>(this.apiUrl);
}
}