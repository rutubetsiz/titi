using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MadamRozikaData.Functions;
using MadamRozikaGlobal.Dtos.ViewDtos;

namespace MadamRozikaData.Services
{

    public class FooterService
    {
        readonly MadamRozikaEntities _db = new MadamRozikaEntities();

        public FooterDto GetFooter()
        {
            return new FooterDto { CategoryMenuListDto = GetMenu(), FooterGalleryListDto = GetFooterGallery(), FooterNewsListDto = GetFooterNews() };
        }

        public List<CategoryMenuDto> GetMenu()
        {
            return (from a in _db.Categories.ToList()
                    orderby a.Rank
                    where a.Status == 1 && a.ParentId == 0 && a.Name != "Anasayfa"
                    select new Mapper().MapTo(a)).ToList();
        }

        public List<FooterNewsDto> GetFooterNews()
        {
            return (from news in _db.News.Where(p => p.Status == 1).OrderByDescending(p => p.PublishDate).Take(5).ToList()
                    join category in _db.Categories.Where(p => p.Status == 1) on news.CategoryId equals category.CategoryId
                    select new FooterNewsDto
                    {
                        CategoryMenu = new Mapper().MapTo(category),
                        NewsMenu = new Mapper().MapTo(news)

                    }).ToList();
        }


        public List<FooterGalleryDto> GetFooterGallery()
        {
            return (from gallery in _db.Galleries.Where(p => p.Status == 1).OrderByDescending(p => p.PublishDate).Take(5).ToList()
                    join category in _db.Categories.Where(p => p.Status == 1) on gallery.CategoryId equals category.CategoryId
                    select new Mapper().MapTo(gallery, category)).ToList();
        }
    }
}
