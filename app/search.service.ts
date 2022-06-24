import { Injectable } from '@angular/core';
import {Movie} from 'src/app/movie';
import {HttpClient,HttpHeaders} from '@angular/common/http';
import {Observable, observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SearchService {

   url="https://localhost:44373/api/Admin";
  constructor(private http:HttpClient) { }
  DisplayAll(){
    return this.http.get("https://localhost:44373/api/Admin");
  }
  searchmovie(id:string):Observable<Movie>{
    let httpheaders=new HttpHeaders().set('Content-Type','application/json');
    return this.http.get<Movie>(this.url+"/"+id);
  }
}
