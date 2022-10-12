﻿using Week15Project.Models;

namespace Week15Project.Services
{
    public interface IForumRepository
    {
        #region Room
        void AddRoom(Room room);
        List<Room> GetAllRooms();
        Room GetRoom(int id);
        #endregion

        #region User
        User GetUser(string id);
        User GetUserByName(string username);
        #endregion

        #region Post
        void AddPost(Post post);
        List<Post> GetAllPosts(int roomID);
        Post GetPost(int id);
        List<Post> GetPostsByUser(string userId);
        Post GetNewestPost();
        Post GetMostPopularPostToday();
        #endregion

        #region Response
        void AddResponse(Response message);
        List<Response> GetAllResponses(int postId);
        List<Response> GetResponsesByUser(string userId);
        #endregion

        #region Other
        int GetPostCountPerRoom(int roomId);
        #endregion

        //void AddUser(User user);
        //List<User> GetAllUsers();
        //Response GetResponse(int id);
        //void UpdateUser(User user);
        //void UpdateRoom(Room room);
        //void UpdatePost(Post post);
        //void UpdateResponse(Response message);
        //void DeleteUser(int id);
        //void DeleteRoom(int id);
        //void DeletePost(int id);
        //void DeleteResponse(int id);
    }
}
