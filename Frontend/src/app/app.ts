import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ApiService } from './services/api';
import { ResumeData } from './models/resume-models';
import { HeroComponent } from './components/hero/hero';
import { AboutComponent } from './components/about/about';
import { ExperienceComponent } from './components/experience/experience';
import { EducationComponent } from './components/education/education';
import { SkillsComponent } from './components/skills/skills';
import { ContactComponent } from './components/contact/contact';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [
    CommonModule,
    HeroComponent,
    AboutComponent,
    ExperienceComponent,
    EducationComponent,
    SkillsComponent,
    ContactComponent
  ], // Importing child components
  templateUrl: './app.html',
  styleUrls: ['./app.css']
})
export class AppComponent implements OnInit {
  title = 'cv-app';
  resumeData?: ResumeData;

  constructor(private apiService: ApiService) { }

  ngOnInit(): void {
    this.apiService.getResume().subscribe(data => {
      this.resumeData = data;
    });
  }
}
