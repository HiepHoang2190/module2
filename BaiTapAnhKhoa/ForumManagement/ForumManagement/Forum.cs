using System;
using System.Collections.Generic;
using System.Text;

namespace ForumManagement
{
    class Forum:Post
    {
        public SortedList<int, Post> Posts = new SortedList<int, Post>();

        public void Add(Post post)
        {
            Posts.Add(post.Id, post);
          
        }
        public void RemovePost(int Id)
        {
            if (CheckPost(Id))
            {
                Posts.Remove(Id);
            }
            else
            {
                Console.WriteLine("Invalid Post");
            }
        }
        public void UpdatePost(int Id, string newcontent)
        {

            if (CheckPost(Id))
            {
                Posts[Id].Content = newcontent;
            }
            else
            {
                Console.WriteLine("Invalid Post");
            }
        }
    
      
        public void Show()
        {
            foreach(Post item in Posts.Values)
            {
                Console.WriteLine(item.Display());
            }
        }
        public void Search(string keyword)
        {   
            bool found=false;
            keyword = keyword.ToLower();
            foreach(var post in Posts.Values)
            {
                if(post.Author.ToLower().Contains(keyword)|| post.Title.ToLower().Contains(keyword))
                {
                    Console.WriteLine(post.Display());
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Not Found");
            }
        }

        public void Rating(int postId, int rate)
        {
            if (CheckPost(postId))
            {
                Posts[postId].Rates.Add(rate);
            }
            else
            {
                Console.WriteLine("Invalid Post");
            }
        }
        private bool CheckPost(int postId)
        {
              
           foreach(var post in Posts.Values)
            {
                if(post.Id== postId)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
