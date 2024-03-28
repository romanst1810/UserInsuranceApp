
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PolicyService {
  private apiUrl = 'http://localhost:5000/api/Policies'; // Replace with your API endpoint

  constructor(private http: HttpClient) { }

  getPoliciesForUser(userId: number): Observable<any> {
    return this.http.get(`${this.apiUrl}/user/${userId}/policies`);
  }

  getPolicies(): Observable<any> {
    return this.http.get(this.apiUrl);
  }

  getPolicy(id: number): Observable<any> {
    return this.http.get(`${this.apiUrl}/${id}`);
  }

  addPolicy(Policy: any): Observable<any> {
    return this.http.post(this.apiUrl, Policy);
  }

  updatePolicy(id: number, Policy: any): Observable<any> {
    return this.http.put(`${this.apiUrl}/${id}`, Policy);
  }

  deletePolicy(id: number): Observable<any> {
    return this.http.delete(`${this.apiUrl}/${id}`);
  }
}
