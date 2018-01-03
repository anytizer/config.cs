using configs.classes.structures;

namespace configs.classes.interfacing
{
    public abstract class config_smtp : iconfigwriter
    {
        public abstract structure_smtp read();
        public abstract bool write(structure_smtp s);
    }
}
