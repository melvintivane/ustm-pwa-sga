import "./Home.css";
import svg from "../../assets/iconCarrier.svg";

const Home = () => {
  return (
    <div className="home__container">
      <div className="home__left">
        <p className="home__text">
          Seja bem ao <b>Krupp</b> o <br />
          seu sistema de gestão <br />
          académica.
        </p>
        <button>Ver Notas</button>
      </div>
      <div className="home__right">
        <img className="home__img" src={svg} alt="" />
      </div>
    </div>
  );
};

export default Home;
