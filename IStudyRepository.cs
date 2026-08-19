interface IStudyRepository
{
    void Save(StudyTopic topic);
    StudyTopic? GetByName(string name);
}