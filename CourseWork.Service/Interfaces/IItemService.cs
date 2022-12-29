﻿using CourseWork.Domain.Entities;
using CourseWork.Domain.Response;
using CourseWork.Domain.ViewModels.Item;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Service.Interfaces
{
	public interface IItemService
	{
		Task<IBaseResponse<List<Item>>> GetItems();
		Task<IBaseResponse<ItemViewModel>> GetItem(string id);
		Task<IBaseResponse<Item>> Create(CreateItemViewModel model, string username);
		Task<IBaseResponse<Item>> Edit(ItemViewModel model);
		Task<IBaseResponse<bool>> Delete(string id);
	}
}
