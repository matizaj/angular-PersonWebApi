import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders} from '@angular/common/http';
import { Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import { Person } from './person';
import { catchError, map, tap } from 'rxjs/operators';

const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

@Injectable()
export class PersonService {
  constructor(private http: HttpClient) { }

  getPeople(): Observable<Person[]> {
    const apiUrl = 'api/person/GetAll';
    return this.http.get<Person[]>(apiUrl); }

    addPerson(person: Person): Observable<Person> {
      const apiUrl = 'api/person/create';
      return this.http.post<Person>(apiUrl, person, httpOptions);
    }

  }


  // addPerson (person: Person): Observable<Person> {
  //   const apiUrl = 'api/person/create';
  //   return this.http.post<Person>(this.heroesUrl, person, httpOptions);
  //   );
  // }
