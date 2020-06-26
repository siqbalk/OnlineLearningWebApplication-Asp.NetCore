using System.Collections.Generic;
using AcademicApplication.Models;

namespace AcademicApplication.Data
{
    public interface IEFRepository
    {
        void Add(object entity);
        int CartCount();
        int CoursesCount();
        void Delete(object entity);
        CourseCart GetCartById(int id, bool includeDetail = false);
        IEnumerable<CourseCart> GetCarts(bool includeDetail = false);
        IEnumerable<CourseCart> GetCartsByUserId(string id, bool includeDetail = false);
        Course GetCourse(int id, bool IncludeDetail = false);
        IEnumerable<Course> getCourses(bool IncludeDetail = false);
        IEnumerable<Course> GetCourses(int id, bool IncludeDetail = false);
        PagedList<Course> GetCourses(QueryOptions options, int subjectId, int price, int courseId, bool IncludeDetail = false);
        IEnumerable<Course> GetCoursesByPrice(int price, bool IncludeDetail = false);
        IEnumerable<Course> GetCoursesBySubejctId(int subjectId, bool IncludeDetail = false);
        PagedList<Course> GetCoursesBySubId(QueryOptions options, int id, bool IncludeDetail = false);
        IEnumerable<Course> GetFilteredCourse(string subject = null, decimal? price = null, bool IncludeDetail = false);
        IEnumerable<PaidCourses> GetPaidCoursesByUserId(string id, bool IncludeDetail = false);
        IEnumerable<SalesTarget> GetSalesTarget();
        Subject GetSubject(int id, bool includeDetail = false);
        IEnumerable<Subject> GetSubjects(bool IncludeDetail = false);
        IEnumerable<CourseSubscribe> GetSubscribe(bool IncludeDetail = false);
        IEnumerable<CourseSubscribe> GetSubscribeByCourseId(int id, bool IncludeDetail = false);
        CourseSubscribe GetSubscribedCours(int id, bool includeDetail = false);
        IEnumerable<CourseSubscribe> GetSubscribedCourses(string id, bool includeDetail = false);
        Topic GetTopic(int id, bool includeDetail = false);
        IEnumerable<Topic> GetTopics(bool includeDetail = false);
        IEnumerable<Topic> GetTopics(int id, bool includeDetail = false);
        int RoleCount();
        bool SaveChange();
        int SubjectCount();
        PagedList<Subject> Subjects(QueryOptions options, bool IncludeDetail = false);
        int TopicCount();
        void Update(object entity);
        int UserCount();
    }
}