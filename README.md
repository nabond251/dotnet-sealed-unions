<!-- Improved compatibility of back to top link: See: https://github.com/othneildrew/Best-README-Template/pull/73 -->
<a name="readme-top"></a>
<!--
*** Thanks for checking out the Best-README-Template. If you have a suggestion
*** that would make this better, please fork the repo and create a pull request
*** or simply open an issue with the tag "enhancement".
*** Don't forget to give the project a star!
*** Thanks again! Now go create something AMAZING! :D
-->



<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]



<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/nabond251/dotnet-sealed-unions">
    <img src="images/logo.png" alt="Logo" width="80" height="80">
  </a>

<h3 align="center">.NET Sealed Unions</h3>

  <p align="center">
    Yet Another Coproducts Port
    <br />
    <a href="https://github.com/nabond251/dotnet-sealed-unions"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <a href="https://github.com/nabond251/dotnet-sealed-unions">View Demo</a>
    ·
    <a href="https://github.com/nabond251/dotnet-sealed-unions/issues">Report Bug</a>
    ·
    <a href="https://github.com/nabond251/dotnet-sealed-unions/issues">Request Feature</a>
  </p>
</div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li><a href="#about-the-project">About The Project</a></li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgments">Acknowledgments</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project

This is a .NET port of
[Francisco](https://github.com/pakoito/) ([Paco](https://github.com/pakoito/)) [Estévez
](https://github.com/pakoito/)'s
[JavaSealedUnions](https://github.com/pakoito/JavaSealedUnions/blob/master/README.md).

> In [computer science](https://en.wikipedia.org/wiki/Computer_science), a
  **tagged union**, also called a **variant**, **variant record**,
  **choice type**, **discriminated union**,
  [**disjoint union**](https://en.wikipedia.org/wiki/Disjoint_union),
  **sum type** or [**coproduct**](https://en.wikipedia.org/wiki/Coproduct), is
  a data structure used to hold a value that could take on several different,
  but fixed, types.

&mdash; Wikipedia, [Tagged Union](https://en.wikipedia.org/wiki/Tagged_union)

And apparently now "sealed union" works, too.  This structure is the
counterpart to the tuple.  A tuple allows you to form expressions which model
`data0` *and* `data1` *and* `data2`; a tagged union allows you to model `data0`
*or* `data1` *or* `data2`.  Several languages either support this structure
natively, or have supplied a library implementing it.  The sealed union flavor
is a simple, elegant implementation of such a library, so here it is for .NET.

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- USAGE EXAMPLES -->
## Usage

A simple way to get a feel for the workings of this library would be to clone
this repository and run the xUnit tests.  One implements the Tennis kata (see
[The Tennis kata revisited](https://blog.ploeh.dk/2021/08/03/the-tennis-kata-revisited/)
by Mark Seemann).

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- ROADMAP -->
## Roadmap

- [ ] Improve documentation
- [ ] Integrate with C# 9 `switch` pattern matching

See the [open issues](https://github.com/nabond251/dotnet-sealed-unions/issues) for a full list of proposed features (and known issues).

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

If you have a suggestion that would make this better, please fork the repo and create a pull request. You can also simply open an issue with the tag "enhancement".
Don't forget to give the project a star! Thanks again!

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- LICENSE -->
## License

Distributed under the Apache-2.0 license. See `LICENSE.txt` for more information.

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- CONTACT -->
## Contact

Nathaniel Bond - [@bondolin_7](https://twitter.com/bondolin_7) - nabond251@gmail.com

Project Link: [https://github.com/nabond251/dotnet-sealed-unions](https://github.com/nabond251/dotnet-sealed-unions)

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- ACKNOWLEDGMENTS -->
## Acknowledgments

* [JavaSealedUnions](https://github.com/pakoito/JavaSealedUnions)
* [dart_sealed_unions](https://github.com/fluttercommunity/dart_sealed_unions)
* [ploeh blog](https://blog.ploeh.dk/)

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/nabond251/dotnet-sealed-unions.svg?style=for-the-badge
[contributors-url]: https://github.com/nabond251/dotnet-sealed-unions/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/nabond251/dotnet-sealed-unions.svg?style=for-the-badge
[forks-url]: https://github.com/nabond251/dotnet-sealed-unions/network/members
[stars-shield]: https://img.shields.io/github/stars/nabond251/dotnet-sealed-unions.svg?style=for-the-badge
[stars-url]: https://github.com/nabond251/dotnet-sealed-unions/stargazers
[issues-shield]: https://img.shields.io/github/issues/nabond251/dotnet-sealed-unions.svg?style=for-the-badge
[issues-url]: https://github.com/nabond251/dotnet-sealed-unions/issues
[license-shield]: https://img.shields.io/github/license/nabond251/dotnet-sealed-unions.svg?style=for-the-badge
[license-url]: https://github.com/nabond251/dotnet-sealed-unions/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/nathaniel-bond-0642603a
[product-screenshot]: images/screenshot.png
[Next.js]: https://img.shields.io/badge/next.js-000000?style=for-the-badge&logo=nextdotjs&logoColor=white
[Next-url]: https://nextjs.org/
[React.js]: https://img.shields.io/badge/React-20232A?style=for-the-badge&logo=react&logoColor=61DAFB
[React-url]: https://reactjs.org/
[Vue.js]: https://img.shields.io/badge/Vue.js-35495E?style=for-the-badge&logo=vuedotjs&logoColor=4FC08D
[Vue-url]: https://vuejs.org/
[Angular.io]: https://img.shields.io/badge/Angular-DD0031?style=for-the-badge&logo=angular&logoColor=white
[Angular-url]: https://angular.io/
[Svelte.dev]: https://img.shields.io/badge/Svelte-4A4A55?style=for-the-badge&logo=svelte&logoColor=FF3E00
[Svelte-url]: https://svelte.dev/
[Laravel.com]: https://img.shields.io/badge/Laravel-FF2D20?style=for-the-badge&logo=laravel&logoColor=white
[Laravel-url]: https://laravel.com
[Bootstrap.com]: https://img.shields.io/badge/Bootstrap-563D7C?style=for-the-badge&logo=bootstrap&logoColor=white
[Bootstrap-url]: https://getbootstrap.com
[JQuery.com]: https://img.shields.io/badge/jQuery-0769AD?style=for-the-badge&logo=jquery&logoColor=white
[JQuery-url]: https://jquery.com 