
using AcademicApplication.Data;
using AcademicApplication.Models;
using AcademicApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicApplication.ViewComponents
{
    public class SubjectListViewComponent:ViewComponent
    {
        private IEFRepository _repository;

        public SubjectListViewComponent(IEFRepository repository)
        {
            _repository = repository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<SubjectListViewModel> models = null;
            var subjects = _repository.GetSubjects(true);

            if (subjects != null)
            {
                models = subjects.Select(p => new SubjectListViewModel()
                {
                    SubjectId = p.SubjectId,
                    SubjectName = p.Name
                }).ToList();

            }
            return View(models);
        }

        //private Task<List<SubjectListViewModel>> GetItemsAsync()
        //{
        //    //List<SubjectListViewModel> models = null;
        //    //var subjects = _repository.GetSubjects(true);

        //    //if (subjects != null)
        //    //{
        //    //    models = subjects.Select(p => new SubjectListViewModel()
        //    //    {
        //    //        SubjectId = p.SubjectId,
        //    //        SubjectName = p.Name
        //    //    }).ToList();

        //    //}


        //    return  Task.FromResult( models);
        //}
    }
}
