using configs.classes.structures;

namespace configs.classes.interfacing
{
    public abstract class config_mysql : iconfigwriter
    {
        public abstract structure_mysql read();
        public abstract bool write(structure_mysql s);
    }
}
