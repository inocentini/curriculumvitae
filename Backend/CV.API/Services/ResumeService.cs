using CV.API.Models;

namespace CV.API.Services;

public interface IResumeService
{
    ResumeData GetResume();
}

public class ResumeService : IResumeService
{
    public ResumeData GetResume()
    {
        return new ResumeData
        {
            PersonalInfo = new PersonalInfo
            {
                Name = "Mateus Felipe Inocentini",
                Title = "Engenheiro de Software · Especialista em Automação/RPA",
                Location = "São Paulo/SP – Brasil",
                Phone = "+55 (16) 99233-3137",
                Email = "mateus.inocentini@gmail.com",
                LinkedIn = "https://www.linkedin.com/in/mateus-inocentini-6029a2126",
                GitHub = "https://github.com/inocentini",
                PhotoUrl = "assets/profile.jpg", // Will be mapped in frontend
                Summary = "Profissional com mais de 6 anos de experiência em desenvolvimento de software e automação RPA, com foco em tecnologias .NET. Atuação em sustentação de produção, desenvolvimento de correções e melhorias, criação de robôs e scripts, sempre seguindo boas práticas de engenharia de software, padrões de projeto e alto padrão de qualidade. Experiência em ambientes de missão crítica, plantão (on-call) e participação em comitês técnicos, contribuindo para padronização, governança e evolução de soluções."
            },
            Experiences = new List<Experience>
            {
                new Experience
                {
                    Role = "Analista de Sistemas Sênior",
                    Company = "Telefônica Brasil (Vivo)",
                    Period = "fev de 2022 – atual",
                    Location = "São Paulo/SP, Brasil",
                    DescriptionPoints = new List<string>
                    {
                        "Atuação em suporte N3 de automações em produção, desenvolvendo correções, melhorias e novas funcionalidades.",
                        "Participação e liderança em comitês de avaliação técnica para padronização de projetos e desenvolvimento de robôs.",
                        "Implementação de mudanças em produção (GMUD), seguindo processos de governança e gestão de risco.",
                        "Tratativa de chamados de suporte, monitoramento de alarmes e atuação em regime de plantão (on-call).",
                        "Desenvolvimento de aplicação web para gestão de ambientes de produção e inventário de VMs, trazendo maior visibilidade operacional."
                    }
                },
                new Experience
                {
                    Role = "Líder de Equipe de Suporte (N2/N3)",
                    Company = "end-to-end Technology",
                    Period = "out de 2018 – fev de 2022",
                    Location = "",
                    DescriptionPoints = new List<string>
                    {
                        "Desenvolvimento de RPAs e automações de scripts utilizando PowerShell, Batch, VBS e .NET.",
                        "Liderança de equipe de suporte N2 e N3, acompanhamento de desempenho e priorização de demandas.",
                        "Suporte a incidentes críticos, análise de causa raiz e implementação de melhorias contínuas."
                    }
                },
                new Experience
                {
                    Role = "Estagiário de TI",
                    Company = "Instituto Federal de São Paulo (IFSP – Campus São Carlos)",
                    Period = "ago de 2017 – fev de 2018",
                    Location = "São Carlos/SP, Brasil",
                    DescriptionPoints = new List<string>
                    {
                        "Desenvolvimento e manutenção de páginas do site institucional.",
                        "Suporte em TI: instalações, manutenção de equipamentos e apoio em salas de aula.",
                        "Registro e encaminhamento de demandas de informática à Coordenadoria de Tecnologia da Informação."
                    }
                },
                new Experience
                {
                    Role = "Operador de Caixa",
                    Company = "Inbrands S.A.",
                    Period = "dez de 2015 – jun de 2016",
                    Location = "",
                    DescriptionPoints = new List<string>
                    {
                        "Responsável por rotinas administrativas e de caixa, emissão de notas fiscais e controles financeiros.",
                        "Atendimento ao público, organização de estoque e apoio às vendas."
                    }
                },
                new Experience
                {
                    Role = "Auxiliar Administrativo",
                    Company = "Sercont Serviços Contábeis S.A.",
                    Period = "jan de 2011 – dez de 2014",
                    Location = "",
                    DescriptionPoints = new List<string>
                    {
                        "Elaboração de minutas contratuais e processos de abertura, alteração e encerramento de empresas.",
                        "Atuação em legalização de pessoas físicas e jurídicas junto a órgãos municipais e federais.",
                        "Alimentação de planilhas e sistemas, organização de arquivos e suporte administrativo geral."
                    }
                }
            },
            Education = new List<Education>
            {
                new Education
                {
                    Institution = "FIAP",
                    Degree = "Pós-graduação em Arquitetura de Software",
                    Period = "mar de 2025 – jan de 2026 (em andamento)"
                },
                new Education
                {
                    Institution = "Instituto Federal de Educação, Ciência e Tecnologia de São Paulo – IFSP",
                    Degree = "Tecnologia em Análise e Desenvolvimento de Sistemas",
                    Period = "jun de 2016 – jan de 2021"
                }
            },
            Skills = new List<SkillCategory>
            {
                new SkillCategory
                {
                    CategoryName = "Linguagens e Frameworks",
                    Items = new List<string> { "C#", ".NET", "Blazor", "PowerShell", "Batch", "VBScript" }
                },
                new SkillCategory
                {
                    CategoryName = "RPA",
                    Items = new List<string> { "Automation Anywhere", "UiPath", "NICE" }
                },
                new SkillCategory
                {
                    CategoryName = "Dados",
                    Items = new List<string> { "SQL Server", "MongoDB", "MySQL", "Oracle" }
                },
                new SkillCategory
                {
                    CategoryName = "Outros",
                    Items = new List<string> { "Git", "Linux", "Windows", "Governança" }
                }
            },
            Certifications = new List<Certification>
            {
                new Certification { Name = "Lean Six Sigma – Yellow Belt" }
            },
            Languages = new List<Language>
            {
                new Language { Name = "Português", Level = "Nativo" },
                new Language { Name = "Inglês", Level = "Intermediário" }
            }
        };
    }
}
