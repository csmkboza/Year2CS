class StudyService
{
    private readonly IStudyRepository repository;

    public StudyService(IStudyRepository repository)
    {
        this.repository = repository;
    }

    public void AddTopic(StudyTopic topic)
    {
        repository.Save(topic);
    }

    public StudyTopic? FindTopic(Guid id)
    {
        return repository.GetById(id);
    }
}