import {Injectable} from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders, HttpParams  } from '@angular/common/http';

@Injectable()

export class lanchesServices{

    constructor(private httpclient: HttpClient){

    }

    private _httpOptions = {
        headers: new HttpHeaders({
          'Content-Type': 'application/json',
          'Access-Control-Allow-Origin': '*',
          'Access-Control-Allow-Methods': 'GET, POST, OPTIONS, PUT, PATCH, DELETE',
          'Access-Control-Allow-Headers':
            'Access-Control-Allow-Headers, Origin,Accept, X-Requested-With, Content-Type, Access-Control-Request-Method, Access-Control-Request-Headers'
        })
      };

    getLanches(): Observable<any>{
        var ret = this.httpclient.get('https://localhost:44322/api/getalllanches');
        return ret;
    }

    postVendas(codigosLanches): Observable<any>{
        var ret = this.httpclient.get('https://localhost:44322/api/PostVendas?codLanche='+ codigosLanches);
        return ret;
    }
}


