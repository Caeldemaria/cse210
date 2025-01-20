using System;

class Program{

    static void Main(string[] args){
        
        Jobs job_1=new Jobs();
        job_1._jobTitle="English Teacher";
        job_1._company="Invictus Idiomas";
        job_1._startYear=2024;
        job_1._endYear=2025;

        Jobs job_2=new Jobs();
        job_2._jobTitle="Administrative Assistant";
        job_2._company="Invictus Idiomas";
        job_2._startYear=2024;
        job_2._endYear=2025;

        resume resume=new resume();
        resume._name="Pedro Micael";
        resume._Job.Add(job_1);
        resume._Job.Add(job_2);

        resume.Display();
    }
}