PGDMP      -        
        |            TaskDb    16.2    16.2     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    16396    TaskDb    DATABASE     |   CREATE DATABASE "TaskDb" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Russian_Russia.1251';
    DROP DATABASE "TaskDb";
                admin    false            �            1259    16406    Users    TABLE     t   CREATE TABLE public."Users" (
    "Id" integer NOT NULL,
    login "char" NOT NULL,
    password "char" NOT NULL
);
    DROP TABLE public."Users";
       public         heap    postgres    false            �            1259    16405    Users_Id_seq    SEQUENCE     �   CREATE SEQUENCE public."Users_Id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 %   DROP SEQUENCE public."Users_Id_seq";
       public          postgres    false    216            �           0    0    Users_Id_seq    SEQUENCE OWNED BY     C   ALTER SEQUENCE public."Users_Id_seq" OWNED BY public."Users"."Id";
          public          postgres    false    215                       2604    16409    Users Id    DEFAULT     j   ALTER TABLE ONLY public."Users" ALTER COLUMN "Id" SET DEFAULT nextval('public."Users_Id_seq"'::regclass);
 ;   ALTER TABLE public."Users" ALTER COLUMN "Id" DROP DEFAULT;
       public          postgres    false    216    215    216            �          0    16406    Users 
   TABLE DATA           8   COPY public."Users" ("Id", login, password) FROM stdin;
    public          postgres    false    216   N
       �           0    0    Users_Id_seq    SEQUENCE SET     <   SELECT pg_catalog.setval('public."Users_Id_seq"', 1, true);
          public          postgres    false    215                       2606    16411    Users Users_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public."Users"
    ADD CONSTRAINT "Users_pkey" PRIMARY KEY ("Id");
 >   ALTER TABLE ONLY public."Users" DROP CONSTRAINT "Users_pkey";
       public            postgres    false    216            �      x�3���,������ ��     