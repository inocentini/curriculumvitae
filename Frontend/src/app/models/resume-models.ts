export interface ResumeData {
  personalInfo: PersonalInfo;
  experiences: Experience[];
  education: Education[];
  skills: SkillCategory[];
  certifications: Certification[];
  languages: Language[];
}

export interface PersonalInfo {
  name: string;
  title: string;
  location: string;
  phone: string;
  email: string;
  linkedIn: string;
  gitHub: string;
  summary: string;
  photoUrl: string;
}

export interface Experience {
  role: string;
  company: string;
  period: string;
  location: string;
  descriptionPoints: string[];
}

export interface Education {
  institution: string;
  degree: string;
  period: string;
}

export interface SkillCategory {
  categoryName: string;
  items: string[];
}

export interface Certification {
  name: string;
}

export interface Language {
  name: string;
  level: string;
}
