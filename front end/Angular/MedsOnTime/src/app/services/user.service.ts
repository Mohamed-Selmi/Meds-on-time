import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map } from 'rxjs';
import { User } from '../shared/models/user';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  private apiUrl="http://localhost:5275/v1/";
  constructor(private http: HttpClient) { }
  getAllUsers(){
    const headers= new HttpHeaders().set('Access-Control-Allow-Origin','*');
    return this.http.get<any>(`${this.apiUrl}users`,{headers}
    ).pipe(map(res=> <any>res));
  }
  deleteUser(user: User){
        const headers= new HttpHeaders().set('Access-Control-Allow-Origin','*');
    return this.http.delete(`${this.apiUrl}users/${user.id}`,{'observe': 'body',headers})
  };
  addUser(user: User){
    return this.http.post(`${this.apiUrl}users`,user)
  }
}
