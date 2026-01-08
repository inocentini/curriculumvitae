import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ResumeData } from '../models/resume-models';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  private staticUrl = 'assets/resume.json';

  constructor(private http: HttpClient) { }

  getResume(): Observable<ResumeData> {
    console.log('ApiService: Fetching resume from', this.staticUrl);
    return this.http.get<ResumeData>(this.staticUrl);
  }
}

