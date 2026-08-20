interface IStudyRepository
{
    void Save(StudyTopic topic);
    StudyTopic? GetById(Guid id);
}