

using LinqDemo;

#region Courses
var courses = new List<Course>()
{
    new Course()
    {
      Id = 1,
      Name = "Introduction à la programmation en C#",
      LevelId = 1,
      Resources = new List<Resource>()
      {
        new Resource()
        {
            Id = 1,
            Name = "Livre - Introduction à C#",
            courseId = 1
        },
        new Resource()
        {
            Id = 2,
            Name = "Vidéo - Introduction à C#",
            courseId = 1
        }
      }

    },
    new Course()
    {
      Id = 2,
      Name = "Sql",
      LevelId = 1,
      Resources = new List<Resource>()
      {
        new Resource()
        {
            Id = 3,
            Name = "Livre - SQL",
            courseId = 1
        },
        new Resource()
        {
            Id = 4,
            Name = "Vidéo - SQL",
            courseId = 1
        }
      }
    },
    new Course()
    {
      Id = 3,
      Name = "Git",
      LevelId = 1,
      Resources = new List<Resource>()
      {
        new Resource()
        {
            Id = 5,
            Name = "PDF - Git",
            courseId = 1
        }
      }
    },
    new Course()
    {
      Id = 4,
      Name = "Azure",
      LevelId = 2,
      Resources = new List<Resource>()
      {
        new Resource()
        {
            Id = 6,
            Name = "PDF - Azure",
            courseId = 1
        }
      }
    },
    new Course()
    {
      Id = 5,
      Name = "Html",
      LevelId = 1,
      Resources = new List<Resource>()
      {
        new Resource()
        {
            Id = 7,
            Name = "Vidéo - Html",
            courseId = 1
        }
      }
    },
    new Course()
    {
      Id = 6,
      Name = "Programmation Orientée Objet",
      LevelId = 2,
      Resources = new List<Resource>()
      {
        new Resource()
        {
            Id = 8,
            Name = "Livre - POO",
            courseId = 1
        }
      }
    },
    new Course()
    {
      Id = 7,
      Name = "ASP.NET Core MVC",
      LevelId = 3,
      Resources = new List<Resource>()
      {
        new Resource()
        {
            Id = 9,
            Name = "Vidéo - MVC d’ASP.NET Core",
            courseId = 1
        }
      }
    }
};
#endregion

#region resources
var resources = new List<Resource>()
{
    new Resource()
    {
        Id = 1,
        Name = "Livre - Introduction à C#",
        courseId = 1
    },
    new Resource()
    {
        Id = 2,
        Name = "Livre - Linq",
        courseId = 1
    },
    new Resource()
    {
        Id = 3,
        Name = "Livre - Git via Visual Studio",
        courseId = 3
    }
};
#endregion

#region Levels
var levels = new List<Level>()
{
    new Level()
    {
        Id = 1,
        Name = "Débutant"
    },
    new Level()
    {
        Id = 2,
        Name = "Intermédiaire"
    },
    new Level()
    {
        Id = 3,
        Name = "Avancé"
    }
};
#endregion

#region Numbers
var numbers1 = new List<int>() { 1, 10, 3, 3, 10 };
var numbers2 = new List<int>() { 2, 4, 3, 1 };
var numbers3 = new List<int>() { 5, 9, 2, 7, 8 };
#endregion

var result = numbers1.Zip(numbers2, numbers3);

foreach (var item in result)
{
    Console.WriteLine(item);
}