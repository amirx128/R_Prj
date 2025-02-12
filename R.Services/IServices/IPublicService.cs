﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R.Models;
using R.Models.ViewModels;

namespace R.Services.IServices
{
    public interface IPublicService
    {
        public AllDropDownItems GetAllDropDownItems();
        ResultModel<LoginResultModel> login(LoginInputModel model);
        ResultModel<bool> RegisterUser(RegisterUserInputModel model);
        bool SaveCaptcha(SaveCaptchaInputModel saveCaptchaInputModel);
        ResultModel<List<GetOneUserData>> SearchUsers(SearchUsersInputModel model);
        ResultModel<GetOneUserData> GetUserInfo(SelectedItemModel model);
        ResultModel<List<GetAllSentMessageResultModel>> GetMessagesWithOneUser(GetAllMessageInputModel model);
        ResultModel<List<GetMyAllMessagesResultModel>> GetMyAllMessages(SelectedItemModel model);
        ResultModel<List<GetAllSentMessageResultModel>> SendMessage(SendMessageInputModel model);
    }
}
