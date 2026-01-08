import { Component, Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Education } from '../../models/resume-models';

@Component({
  selector: 'app-education',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './education.html',
  styleUrls: ['./education.css']
})
export class EducationComponent {
  @Input() data: Education[] = [];
}
