using aplicattion1.Data.Entities;

namespace aplicattion1.Data
{
    public class SeedDB
    {
        private readonly DataContext _context;

        public SeedDB(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()

        {
            await _context.Database.EnsureCreatedAsync();
            await CheckCoursetypeAsync();


        }

        private async Task CheckCoursetypeAsync()
        {

            if (!_context.CourseTypes.Any())
            {
                _context.CourseTypes.Add(new CourseType{Description = "habiliades Personales",
                    Courses = new List<Course>
                        {
                            new Course() {Name = "Inteligencia emocional" },
                            new Course() {Name = "Habilidades sociales" },
                            new Course() {Name = "Expresión en público" }

                    }



                });


             }

            await _context.SaveChangesAsync();

        }
    }

}


    


