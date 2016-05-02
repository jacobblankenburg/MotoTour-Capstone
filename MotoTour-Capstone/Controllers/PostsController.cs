using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MotoTour_Capstone.Models;


namespace MotoTour_Capstone.Controllers
{
    public class PostsController : ApiController
    {
        private MessageBoardContext _ctx;
        public PostsController()
        {
            this._ctx = new MessageBoardContext();
        }

        // GET api/<controller>
        public IEnumerable<Post> Get()
        {
            return this._ctx.Posts.OrderByDescending(x => x.DatePosted).ToList();
        }
    }
}