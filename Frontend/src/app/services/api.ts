import { Injectable, Inject, PLATFORM_ID } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { isPlatformBrowser } from '@angular/common';
import { ResumeData } from '../models/resume-models';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  private localApiUrl = 'http://localhost:5000/api/resume';
  private staticUrl = 'assets/resume.json';

  constructor(
    private http: HttpClient,
    @Inject(PLATFORM_ID) private platformId: Object
  ) { }

  getResume(): Observable<ResumeData> {
    // If not in browser (SSR), definitely fetch locally or fail gracefully.
    // For simplicity, we try the local API first. If it fails (deployment), fallback to static.

    // Better strategy for deployment: 
    // If hostname is localhost, try API. Else, use static.

    let useStatic = true;

    if (isPlatformBrowser(this.platformId)) {
      const host = window.location.hostname;
      if (host === 'localhost' || host === '127.0.0.1') {
        useStatic = false;
      }
    }

    if (useStatic) {
      return this.http.get<ResumeData>(this.staticUrl);
    } else {
      // Try API, fallback to static if needed
      return this.http.get<ResumeData>(this.localApiUrl).pipe(
        catchError(err => {
          console.warn('API unavailable, falling back to static data', err);
          return this.http.get<ResumeData>(this.staticUrl);
        })
      );
    }
  }
}
