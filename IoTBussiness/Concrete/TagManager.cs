using IoTBussiness.Abstract;
using IoTCore.Utilities;
using IoTCore.Utilities.Results;
using IoTDataAccess.Abstract;
using IoTEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoTBussiness.Concrete
{
    public class TagManager : ITagService
    {
        private readonly ITagDal _tagDal;
        public TagManager(ITagDal tagDal)
        {
            _tagDal = tagDal;
        }
        public IResult Add(Tag tag)
        {
            _tagDal.Add(tag);
            return new SuccessResult(Messages.AddedSuccess);
        }

        public IResult Delete(Tag tag)
        {
            _tagDal.Delete(tag);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Tag>> GetAllTags()
        {
            return new SuccessDataResult<List<Tag>>(_tagDal.GetAll(),Messages.Success);
        }

        public IDataResult<Tag> GetTag(int tagId)
        {
            if (tagId !=0)
            {
                return new SuccessDataResult<Tag>(_tagDal.Get(t => t.ID == tagId), Messages.Success);
            }
            return new ErrorDataResult<Tag>(Messages.IDError);
        }
    }
}
