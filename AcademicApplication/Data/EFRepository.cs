using AcademicApplication.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AcademicApplication.Data
{
    public class EFRepository : IEFRepository
    {
        private AcademicAppDbContext _context;
        #region Constructor
        public EFRepository(AcademicAppDbContext context)
        {
            _context = context;
        }
        #endregion

        #region Generics
        public void Add(object entity)
        {
            _context.Add(entity);
        }

        public void Update(object entity)
        {
            _context.Update(entity);
        }

        public void Delete(object entity)
        {
            _context.Remove(entity);
        }

        public bool SaveChange()
        {
            return _context.SaveChanges() > 0;
        }
        #endregion


        #region Subject

        public IEnumerable<Subject> GetSubjects(bool IncludeDetail = false)
        {
            if (IncludeDetail)
            {
                return _context.subjects
                               .Include(p => p.Courses);
            }
            else
            {
                return _context.subjects;
            }

        }

        public PagedList<Subject> Subjects(QueryOptions options, bool IncludeDetail = false)
        {

            if (IncludeDetail)
            {

                return new PagedList<Subject>(_context.subjects
            .Include(p => p.Courses)
            , options);


            }

            return new PagedList<Subject>(_context.subjects, options);


        }
        public Subject GetSubject(int id, bool includeDetail = false)
        {
            if (includeDetail)
            {
                return _context.subjects
                    .Include(p => p.Courses)
                    .FirstOrDefault(p => p.SubjectId == id);
            }
            else
            {
                return _context.subjects
                    .FirstOrDefault(p => p.SubjectId == id);
            }
        }
        #endregion

        #region Courses

        //reterive courses for searching (by title)
        public IEnumerable<Course> getCourses(bool IncludeDetail = false)
        {
            if (IncludeDetail)
            {
                return _context.courses
                     .Include(p => p.Subject);
            }
            else
            {
                return _context.courses;
            }
        }

        public PagedList<Course> GetCourses(QueryOptions options, int subjectId, int price, int courseId, bool IncludeDetail = false)
        {

            if (IncludeDetail)
            {
                if (subjectId > 0 && price > 0)
                {
                    return new PagedList<Course>(_context.courses
                .Include(p => p.Subject)
                .Where(p => p.Subject.SubjectId == subjectId && p.Price == price)
                , options);
                }
                else if (subjectId > 0 && price <= 0)
                {
                    return new PagedList<Course>(_context.courses
               .Include(p => p.Subject)
               .Where(p => p.Subject.SubjectId == subjectId)
               , options);
                }
                else if (subjectId <= 0 && price > 0)
                {
                    return new PagedList<Course>(_context.courses
              .Include(p => p.Subject)
              .Where(p => p.Price == price)
              , options);
                }
                else if (subjectId <= 0 && price <= 0 && courseId < 0)
                {
                    return new PagedList<Course>(_context.courses
                .Include(p => p.Subject), options);
                }
                else if (subjectId <= 0 && price <= 0 && courseId > 0)
                {
                    return new PagedList<Course>(_context.courses
                .Include(p => p.Subject)
                .Where(p => p.CourseId == courseId)
                , options);
                }
            }

            return new PagedList<Course>(_context.courses, options);


        }


        //------------------------

        public PagedList<Course> GetCoursesBySubId(QueryOptions options, int id, bool IncludeDetail = false)
        {
            if (IncludeDetail)
            {
                return new PagedList<Course>(_context.courses
                    .Include(p => p.Subject)
                    .Where(p => p.Subject.SubjectId == id),
                    options);

            }

            return new PagedList<Course>(_context.courses
                 .Where(p => p.Subject.SubjectId == id),
                 options);
        }



        public IEnumerable<Course> GetCourses(int id, bool IncludeDetail = false)
        {
            if (IncludeDetail)
            {
                return _context.courses
                    .Include(p => p.Subject)
                    .Where(p => p.Subject.SubjectId == id);
            }
            else
            {
                return _context.courses
                    .Where(p => p.Subject.SubjectId == id);
            }
        }


        public IEnumerable<Course> GetCoursesByPrice(int price, bool IncludeDetail = false)
        {
            if (IncludeDetail)
            {
                return _context.courses
                    .Include(p => p.Subject)
                    .Where(p => p.Price == price);
            }
            else
            {
                return _context.courses
                    .Where(p => p.Price == price);
            }
        }


        public IEnumerable<Course> GetCoursesBySubejctId(int subjectId, bool IncludeDetail = false)
        {

            if (IncludeDetail)
            {
                return _context.courses
                    .Include(p => p.Subject)
                    .Where(p => p.Subject.SubjectId == subjectId);
            }

            return _context.courses
                    .Where(p => p.Subject.SubjectId == subjectId);


        }



        public Course GetCourse(int id, bool IncludeDetail = false)
        {
            if (IncludeDetail)
            {
                return _context.courses
                    .Include(p => p.Subject)
                    .FirstOrDefault(p => p.CourseId == id);
            }
            else
            {
                return _context.courses
                    .FirstOrDefault(p => p.CourseId == id);
            }
        }

        public IEnumerable<Course> GetFilteredCourse(string subject = null,
        decimal? price = null, bool IncludeDetail = false)
        {

            IQueryable<Course> data = _context.courses;
            if (subject != null)
            {
                data = data.Where(p => p.Subject.Name == subject);
            }
            if (price != null)
            {
                data = data.Where(p => p.Price >= price);
            }

            return data;


        }


        #endregion

        #region Topic
        public IEnumerable<Topic> GetTopics(bool includeDetail = false)
        {
            if (includeDetail)
            {
                return _context.topics
                    .Include(p => p.Course);
            }
            else
            {
                return _context.topics;
            }
        }

        public IEnumerable<Topic> GetTopics(int id, bool includeDetail = false)
        {
            if (includeDetail)
            {
                return _context.topics
                    .Include(p => p.Course)
                    .Where(p => p.Course.CourseId == id);
            }
            else
            {
                return _context.topics
                     .Where(p => p.Course.CourseId == id);
            }
        }


        public Topic GetTopic(int id, bool includeDetail = false)
        {
            if (includeDetail)
            {
                return _context.topics
                    .Include(p => p.Course)
                    .FirstOrDefault(p => p.TopicId == id);
            }
            else
            {
                return _context.topics
                    .FirstOrDefault(p => p.TopicId == id);
            }
        }
        #endregion


        #region Cart
        public IEnumerable<CourseCart> GetCarts(bool includeDetail = false)
        {
            if (!includeDetail)
            {
                return _context.courseCarts.AsNoTracking().OrderBy(s => s.Price);



            }

            return _context.courseCarts.AsNoTracking().OrderBy(s => s.Price)
                 .Include(p => p.course)
                 .Include(p => p.Appuser);


        }


        #region Subscribe
        public IEnumerable<CourseSubscribe> GetSubscribedCourses(string id, bool includeDetail = false)
        {
            if (includeDetail)
            {
                return _context.courseSubscribes
                    .Include(p => p.Appuser)
                    .Include(p => p.course)
                    .Where(p => p.Appuser.Id == id);



            }

            return _context.courseSubscribes
                       .Where(p => p.Appuser.Id == id);


        }

        public CourseSubscribe GetSubscribedCours(int id, bool includeDetail = false)
        {
            if (!includeDetail)
            {
                return _context.courseSubscribes
                    .Include(p => p.Appuser)
                    .Include(p => p.course)
                    .FirstOrDefault(p => p.CourseSubscribeId == id);



            }

            return _context.courseSubscribes
                    .FirstOrDefault(p => p.CourseSubscribeId == id);


        }
        #endregion


        public IEnumerable<CourseCart> GetCartsByUserId(string id, bool includeDetail = false)
        {
            if (!includeDetail)
            {
                return _context.courseCarts
                    .Where(p => p.Appuser.Id == id);

            }

            return _context.courseCarts
                 .Include(p => p.course)
                 .Where(p => p.Appuser.Id == id);

        }

        public CourseCart GetCartById(int id, bool includeDetail = false)
        {
            if (includeDetail)
            {
                return _context.courseCarts
                    .Include(p => p.Appuser).
                    Include(p => p.course).
                    FirstOrDefault(p => p.CourseCartId == id);
            }

            return _context.courseCarts
                    .FirstOrDefault(p => p.CourseCartId == id);
        }


        public IEnumerable<PaidCourses> GetPaidCoursesByUserId(string id, bool IncludeDetail = false)
        {
            if (IncludeDetail)
            {
                return _context.PaidCourses
                    .Include(p => p.Appuser)
                    .Include(p => p.course)
                    .Where(p => p.Appuser.Id == id);

            }

            return _context.PaidCourses
                    .Where(p => p.Appuser.Id == id);

        }
        #endregion

        #region count
        public int CoursesCount()
        {
            return _context.courses.Count();
        }

        public int UserCount()
        {
            return _context.appUsers.Count();
        }

        public int RoleCount()
        {
            return _context.Roles.Count();
        }

        public int CartCount()
        {
            return _context.courseCarts.Count();
        }

        public int SubjectCount()
        {
            return _context.subjects.Count();
        }

        public int TopicCount()
        {
            return _context.topics.Count();
        }
        #endregion


        #region SalesTarget

        public IEnumerable<SalesTarget> GetSalesTarget()
        {
            return _context.salesTargets;
        }

        #endregion


        #region Subscription
        public IEnumerable<CourseSubscribe> GetSubscribeByCourseId(int id, bool IncludeDetail = false)
        {
            if (IncludeDetail)
            {
                return _context.courseSubscribes
            .Include(p => p.course)
            .Include(p => p.Appuser)
            .Where(p => p.course.CourseId == id);
            }
            return _context.courseSubscribes
            .Where(p => p.course.CourseId == id);

        }


        public IEnumerable<CourseSubscribe> GetSubscribe(bool IncludeDetail = false)
        {
            if (IncludeDetail)
            {
                return _context.courseSubscribes
            .Include(p => p.course)
            .Include(p => p.Appuser);
            }
            return _context.courseSubscribes;

        }
        #endregion


    }
}

