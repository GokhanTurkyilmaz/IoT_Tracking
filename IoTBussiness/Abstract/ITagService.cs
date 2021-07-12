using IoTCore.Utilities.Results;
using IoTEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoTBussiness.Abstract
{
    public interface ITagService
    {
        IDataResult<List<Tag>> GetAllTags();
        IDataResult<Tag> GetTag(int tagId);
        IResult Add(Tag tag);
        IResult Delete(Tag tag);
    }
}
