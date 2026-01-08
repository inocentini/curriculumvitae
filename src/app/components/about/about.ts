import { Component, Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PersonalInfo } from '../../models/resume-models';

@Component({
  selector: 'app-about',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './about.html',
  styleUrls: ['./about.css']
})
export class AboutComponent {
  @Input() data?: PersonalInfo;
}
